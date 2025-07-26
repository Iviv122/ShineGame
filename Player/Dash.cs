using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Dash : MonoBehaviour
{
    [SerializeField] InputManager input;
    [SerializeField] PlayerState PlayerState;
    [SerializeField] float Radius;
    [SerializeField] float GameSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] LineRenderer line;
    private bool state = false;
    Vector2 mousePos;
    private void Awake()
    {
        input.Shift += TryDash;
        input.Look += GetMousePos;
        line.enabled = false;
    }
    private void TryDash()
    {
        if (PlayerState.state == PlayerStates.Grounded)
        {
            SetState();
        }
    }
    private void SetState()
    {
        if (!state)
        {
            line.enabled = true;
            Time.timeScale = GameSpeed;
            SetLine();
        }
        else
        {
            line.enabled = false;
            Time.timeScale = 1;
            Move();
            line.enabled = false;
        }
        state = !state;
    }
    private void GetMousePos(Vector2 delta)
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SetLine();
    }
    private void SetLine()
    {
        line.positionCount = 2;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, mousePos);
    }
    private void Move()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
    
}