using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

public class LevelEnd : MonoBehaviour
{
    [SerializeField, Scene] string GoTo;
    [SerializeField, Tag] string PlayerTag;
    EndBus endBus;
    [Inject]
    public void Construct(EndBus endBus)
    {
        this.endBus = endBus;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == PlayerTag)
        {
            endBus.NextLevel = GoTo;
            endBus.End();
        }
    }
}
