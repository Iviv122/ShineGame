using NaughtyAttributes;
using UnityEngine;

public class DashCharger : MonoBehaviour
{
    [SerializeField, Tag] string PlayerTag;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == PlayerTag)
        {
            Charge(other.gameObject.GetComponent<DashController>());
        }
    }
    private void Charge(DashController controller)
    {
        controller.ChargeDash();
        Destroy(gameObject);
    }
}
