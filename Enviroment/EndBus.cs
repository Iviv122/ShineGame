using System;

public class EndBus 
{
    public event Action OnEnd;
    public string NextLevel;
    public void End()
    {
        OnEnd?.Invoke();
    }
}