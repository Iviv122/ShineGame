using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField, Scene] string GoTo;
    [SerializeField, Tag] string PlayerTag;
    [SerializeField] ScreenEffect effect;
    [SerializeField] float EffectTime;
    [SerializeField] EndBus endBus;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == PlayerTag)
        {
            endBus.End();
            End();
        }
    }
    void End()
    {
        effect.OnEnd += Go;
        effect.DoEffect(EffectTime);
    }
    void Go()
    {
        SceneManager.LoadScene(GoTo, LoadSceneMode.Single);
    }
}
