using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DeathBus", menuName = "Player/DeathBus", order = 0)]
public class DeathBus : ScriptableObject
{
    public event Action OnDeath;
    public void Die()
    {
        OnDeath?.Invoke();
    }
}