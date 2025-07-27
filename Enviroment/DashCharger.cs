using NaughtyAttributes;
using UnityEngine;
using VContainer;

public class DashCharger : MonoBehaviour
{
    [SerializeField, Tag] string PlayerTag;
    private DashController DashController;
    [Inject]
    public void Construct(DashController dashController)
    {
        this.DashController = dashController;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == PlayerTag)
        {
            Charge();
        }
    }
    private void Charge()
    {

        DashController.ChargeDash();
        Destroy(gameObject);
    }
}
