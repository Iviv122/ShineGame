using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    InputSystem_Actions inputs;
    public event Action<Vector2> Move;
    public event Action<Vector2> Look;
    public event Action Shift;
    public event Action Attack;
    public event Action Restart;
    public InputManager()
    {

        inputs = new();

        inputs.Player.Move.performed += OnMove;
        inputs.Player.Restart.performed += OnRestart;
        inputs.Player.Look.performed += OnLook;
        inputs.Player.Attack.performed += OnAttack;

        inputs.Player.Move.Enable();
        inputs.Player.Restart.Enable();
        inputs.Player.Look.Enable();
        inputs.Player.Attack.Enable();
    }
    private void OnMove(InputAction.CallbackContext obj)
    {
        Vector2 dir = obj.ReadValue<Vector2>();
        Debug.Log(dir);
        Move?.Invoke(dir);
    }
    private void OnLook(InputAction.CallbackContext obj)
    {
        Vector2 dir = obj.ReadValue<Vector2>();
        Debug.Log(dir);
        Look?.Invoke(dir);
    }
    private void OnAttack(InputAction.CallbackContext obj)
    {
        Attack?.Invoke();
    }
    private void OnRestart(InputAction.CallbackContext obj)
    {
        Restart?.Invoke();
    }
}