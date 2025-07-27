using NaughtyAttributes;
using UnityEngine;

public class KillCollider : MonoBehaviour
{
    [SerializeField, Tag] string PlayerTag;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == PlayerTag)
        {
            collision.gameObject.GetComponent<PlayerDeath>().Die();
        }
    }
}
