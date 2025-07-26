using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    [SerializeField] StartBus startBus;
    [SerializeField] EndBus endBus;
    [SerializeField] FadeIn fadeIn;
    [SerializeField] FadeOut fadeOut;
    private void Awake()
    {
        if (fadeIn != null && fadeOut != null)
        {
            startBus.OnStart += () =>
           {
               fadeOut.DoEffect(1);
           };
            endBus.OnEnd += () =>
            {
                fadeOut.DoEffect(1);
            };
        }

    }
}