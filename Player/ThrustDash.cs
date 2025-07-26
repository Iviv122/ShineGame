using UnityEngine;

public class ThrustDash : MonoBehaviour
{
    [SerializeField] InputManager input;
    [SerializeField] PlayerState PlayerState;
    [SerializeField] PlayerStates WhenCanDash;
    [SerializeField] float DashSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] DirectionDraw line;
    [SerializeField] ParticleSystem ReadyParticle;
    private bool state = false;
    private void Awake()
    {
        input.Attack += TryDash;
    }
    private void TryDash()
    {
        if (PlayerState.state == WhenCanDash)
        {
            SetState();
        }
    }
    private void SetState()
    {
        if (state)
        {
            Move();
        }
        line.Switch();

        var emmision = ReadyParticle.emission;
        emmision.enabled = !emmision.enabled; 

        state = !state;
    }
    private void Move()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        rb.linearVelocity = (mousePos - (Vector2)transform.position).normalized * DashSpeed;
    }

}