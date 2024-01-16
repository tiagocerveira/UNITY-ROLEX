using UnityEngine;

public class ObjectOrbit : MonoBehaviour
{
    public Transform target;  // The object to orbit around
    public float rotationSpeed = 5f;

    void Update()
    {
        if (target == null)
        {
            Debug.LogWarning("Please assign a target for the camera to orbit around.");
            return;
        }

        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X");

        // Rotate the camera around the target based on mouse input
        transform.RotateAround(target.position, Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
    }
}
