using System;
using UnityEngine;
using UnityEngine.UI;

abstract public class ScreenEffect : MonoBehaviour
{
    [SerializeField] protected RawImage img;
    public event Action OnEnd;
    abstract public void DoEffect(float Time);
    public void End()
    {
        OnEnd?.Invoke();
    }
    protected void OnDestroy() {
        StopAllCoroutines();
    }
}