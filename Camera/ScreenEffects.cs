using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

public class ScreenEffects : MonoBehaviour
{
    [SerializeField] FadeIn fadeIn;
    [SerializeField] FadeOut fadeOut;

    InputManager inputManager;
    EndBus endBus;
    DeathBus deathBus;
    [Inject]
    public void Construct(InputManager inputManager, EndBus endBus, DeathBus deathBus)
    {
        this.inputManager = inputManager;
        this.endBus = endBus;
        this.deathBus = deathBus;
    }
    private void Awake()
    {
        fadeOut.DoEffect(1);

        endBus.OnEnd += End;
        deathBus.OnDeath += Restart;
        inputManager.Restart += Restart;
    }
    private void End()
    {
        fadeIn.DoEffect(0.5f);
        SceneManager.LoadSceneAsync(endBus.NextLevel);
        //fadeIn.OnEnd += () =>
        //{
        //    SceneManager.LoadScene(endBus.NextLevel);
        //};
    }
    private void Restart()
    {
        fadeIn.DoEffect(0.5f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        //fadeIn.OnEnd += () =>
        //{
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //};
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}