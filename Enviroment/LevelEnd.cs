using NaughtyAttributes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField, Scene] string GoTo;
    [SerializeField, Tag] string PlayerTag;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == PlayerTag)
        {
            Translate();
        }
    }
    void Translate()
    {
        Go();
    }
    void Go()
    {
        SceneManager.LoadScene(GoTo, LoadSceneMode.Single);
    }
}
