using System;
public class DeathBus 
{
    public event Action OnDeath;
    public void Die()
    {
        OnDeath?.Invoke();
    }
}