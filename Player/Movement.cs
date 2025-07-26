using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] PlayerState PlayerState;
    [SerializeField] InputManager input;
    [SerializeField] float MoveSpeed;
    [SerializeField] Rigidbody2D rb;
    private float dir;
    private void Awake()
    {
        input.Move += ChangeDir;
    }
    private void ChangeDir(Vector2 dir)
    {
        this.dir = dir.normalized.x;
    }
    void FixedUpdate()
    {
        if (PlayerState.state == PlayerStates.Grounded)
        {
            rb.linearVelocity = new Vector2(dir * MoveSpeed, rb.linearVelocityY);
        }
    }
    
    
}
