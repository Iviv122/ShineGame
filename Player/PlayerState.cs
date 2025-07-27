using System;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public PlayerStates state { get; private set; }

    [Header("Ground Check")]

    [SerializeField] float Heigth;
    [SerializeField] float ColHeight;
    [SerializeField] float ColWidth;
    [SerializeField] LayerMask ground;
    public event Action OnGroundTouch;
    private Transform _transform;
    private void Awake() {
        _transform = transform;
    }
    public void Update()
    {
        HandleState();
    }
    public void HandleState()
    {
        if (IsOnGround())
        {
            state = PlayerStates.Grounded;
            OnGroundTouch?.Invoke();
        }
        else
        {
            state = PlayerStates.Air;
        }
    }
    private bool IsOnGround()
    {
        return Physics2D.BoxCast(_transform.position, new Vector3(ColWidth, ColHeight), 0, Vector2.down, Heigth, ground);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(_transform.position + Vector3.down * Heigth, new Vector3(ColWidth, ColHeight));
    }
}
public enum PlayerStates
{
    Grounded,
    Air,
}