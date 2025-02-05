using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    public Camera mainCamera;
    public float zoomSpeed = 5f;
    public float minZoom = 5f;
    public float maxZoom = 20f;

    private void Update()
    {
        // Retrieve the scroll wheel input
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        // Calculate the new zoom level
        float newZoom = mainCamera.fieldOfView - scrollInput * zoomSpeed;
        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);

        // Apply the new zoom level to the camera
        mainCamera.fieldOfView = newZoom;
    }
}