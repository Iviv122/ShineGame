using UnityEngine;

public class LevelStart : MonoBehaviour
{
    [SerializeField] StartBus startBus;
    private void Start()
    {
        if (startBus != null)
        {
            startBus.Start();
        }
    }
}