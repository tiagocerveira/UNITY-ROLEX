using UnityEngine;

public class WatchRotator : MonoBehaviour
{
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Rotate the watch 360 degrees around its own axis
            transform.Rotate(Vector3.up, 360f, Space.Self);
        }
    }
}
