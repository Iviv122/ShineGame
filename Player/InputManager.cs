using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
    InputSystem_Actions inputs;
    public event Action<Vector2> Move;
    public event Action<Vector2> Look;
    public event Action Shift;
    public event Action Attack;
    private void Awake()
    {
        inputs = new();
    }
    void OnEnable()
    {
        inputs.Player.Move.performed += OnMove;
        inputs.Player.Restart.performed += OnRestart;
        inputs.Player.Sprint.performed += OnShift;
        inputs.Player.Look.performed += OnLook;
        inputs.Player.Attack.performed += OnAttack;

        inputs.Player.Sprint.Enable();
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
    private void OnShift(InputAction.CallbackContext obj)
    {
        Debug.Log("OnShift");
        Shift?.Invoke();
    }
    private void OnAttack(InputAction.CallbackContext obj)
    {
        Debug.Log("OnShift");
        Attack?.Invoke();
    }
    private void OnRestart(InputAction.CallbackContext obj)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnDestroy()
    {
        inputs.Player.Sprint.Disable();
        inputs.Player.Move.Disable();
        inputs.Player.Restart.Disable();
    }
}