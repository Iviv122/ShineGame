using UnityEngine;

public class ThrustDash : Dash 
{
    [SerializeField] float DashSpeed = 9;
    public override void Move(Rigidbody2D rb)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        rb.linearVelocity = (mousePos - (Vector2)rb.transform.position).normalized * DashSpeed;
    }
}