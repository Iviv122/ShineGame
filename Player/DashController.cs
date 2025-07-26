using UnityEngine;

public class DashController : MonoBehaviour
{
    [SerializeField] InputManager input;
    [SerializeField] PlayerState PlayerState;
    [SerializeField] PlayerStates WhenCanDash;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] DirectionDraw line;
    [SerializeField] ParticleSystem ReadyParticle;
    Dash dash;
    private bool state = false;
    private void Awake()
    {
        dash = new ThrustDash();
        input.Attack += Dash;
    }
    public void Dash()
    {
        dash.Move(rb);
    } 
}