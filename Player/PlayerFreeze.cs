using UnityEngine;

public class PlayerFreeze : MonoBehaviour
{
    [SerializeField] EndBus endBus;
    [SerializeField] Rigidbody2D rb;
    private void Awake() {
        endBus.OnEnd += () =>
        {
            rb.simulated = false;
        };
    }
}