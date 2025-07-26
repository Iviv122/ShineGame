using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] DeathBus DeathBus;
    public void Die()
    {
        if (DeathBus != null)
        {
            DeathBus.Die();
        }
        Destroy(gameObject);
    }
}
