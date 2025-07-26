using UnityEngine;
using VContainer;

public class DashController : MonoBehaviour
{
    InputManager input;
    [SerializeField] PlayerState PlayerState;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] DirectionDraw line;
    [SerializeField] ParticleSystem ReadyParticle;
    Dash dash;
    private bool state = false;
    private bool canDash = false;
    [Inject]
    public void Construct(InputManager inputManager)
    {
        input = inputManager;
        input.Attack += TryDash;
    }
    private void Awake()
    {
        dash = new ThrustDash();
        PlayerState.OnGroundTouch += ChargeDash;

        DisChargeDash();
    }
    public void TryDash()
    {
        if (canDash)
        {
            if (state)
            {
                Dash();
            }
            state = !state;
            line.Switch();
        }
    }
    private void ChargeDash()
    {
        canDash = true;
        var emission = ReadyParticle.emission;
        emission.enabled = true;
    }
    private void DisChargeDash()
    {
        canDash = false;
        var emission = ReadyParticle.emission;
        emission.enabled = false;
    }
    private void Dash()
    {
        dash.Move(rb);
        DisChargeDash();
    }
    private void OnDestroy()
    {
        input.Attack -= TryDash;
        PlayerState.OnGroundTouch -= ChargeDash;
    }
}