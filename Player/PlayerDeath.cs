using UnityEngine;
using VContainer;
public class PlayerDeath : MonoBehaviour
{
    DeathBus DeathBus;
    [Inject]
    public void Construct(DeathBus deathBus)
    {
        DeathBus = deathBus;
    }
    public void Die()
    {
        DeathBus.Die();
        Destroy(gameObject);
    }
}
