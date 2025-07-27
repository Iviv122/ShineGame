using UnityEngine;

public class ThrustDash : Dash 
{
    [SerializeField] float DashSpeed = 9;
    public override void Move(Rigidbody2D rb,Transform transform)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        rb.linearVelocity = (mousePos - (Vector2)transform.position).normalized * DashSpeed;
    }
}