using System;
using UnityEngine;

[CreateAssetMenu(fileName = "EndBus", menuName = "Game/EndBus", order = 0)]
public class EndBus : ScriptableObject
{
    public event Action OnEnd;
    public void End()
    {
        OnEnd?.Invoke();
    } 
}