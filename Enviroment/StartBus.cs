using System;
using UnityEngine;

[CreateAssetMenu(fileName = "StartBus", menuName = "Game/StartBus", order = 0)]
public class StartBus : ScriptableObject
{
    public event Action OnStart;
    public void Start()
    {
        OnStart?.Invoke();
    }
}