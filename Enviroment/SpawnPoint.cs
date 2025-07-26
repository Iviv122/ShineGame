using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject PlayerPrefab;
    [SerializeField] DeathBus DeathBus;
    private void Awake()
    {
        DeathBus.OnDeath += Spawn;
        Spawn();
    }
    private void Spawn()
    {
        Instantiate(PlayerPrefab,transform.position,Quaternion.identity,null);
    }
}
