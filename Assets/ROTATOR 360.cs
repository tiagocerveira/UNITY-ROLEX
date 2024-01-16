using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;
            transform.Rotate(Vector3.up, delta.x * 0.5f, Space.World);
            lastMousePosition = Input.mousePosition;
        }
    }
}
