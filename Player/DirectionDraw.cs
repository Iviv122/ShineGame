using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DirectionDraw : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    private Camera cam;
    private Vector2 mousePos;
    private void Awake()
    {
        line.enabled = false;
        cam = Camera.main;
    }
    public void Switch()
    {
        line.enabled = !line.enabled;
    }
    private void Update()
    {
        if (line.enabled)
        {
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            SetLine();
        }
    }
    private Vector2 GetEndPoint()
    {
        Vector2 pos = Physics2D.Raycast(transform.position, mousePos - (Vector2)transform.position, (mousePos - (Vector2)transform.position).magnitude).point;
        return (pos != Vector2.zero) ? pos : mousePos;
    }
    private void SetLine()
    {
        line.positionCount = 2;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, GetEndPoint());
    }
}

