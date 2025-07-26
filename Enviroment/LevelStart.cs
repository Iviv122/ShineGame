using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] ScreenEffect FadeOut;
    [SerializeField] float EffectTime;
    private void Start() {
        FadeOut.DoEffect(EffectTime); 
    }
}