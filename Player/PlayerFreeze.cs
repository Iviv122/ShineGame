using UnityEngine;
using VContainer;

public class PlayerFreeze : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [Inject]
    public void Construct(EndBus endBus)
    {
        endBus.OnEnd += () =>
        {
            rb.simulated = false;
        };
    }
}