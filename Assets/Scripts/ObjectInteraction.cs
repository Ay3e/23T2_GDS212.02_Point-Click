using UnityEngine;
using System.Collections;

public class ObjectInteraction : MonoBehaviour
{
    public Camera mainCamera;
    public float zoomSpeed = 5f;
    public float maxZoom = 10f;
    public float minZoom = 2f;

    private bool isZoomed = false;
    private float defaultFOV;

    private void Start()
    {
        defaultFOV = mainCamera.fieldOfView;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    ZoomIn();
                }
                else
                {
                    ZoomOut();
                }
            }
        }
    }

    private void ZoomIn()
    {
        if (isZoomed)
            return;

        isZoomed = true;
        float targetFOV = mainCamera.fieldOfView / zoomSpeed;
        targetFOV = Mathf.Clamp(targetFOV, minZoom, maxZoom);

        // Animate the camera zoom
        StartCoroutine(AnimateZoom(targetFOV));
    }

    private void ZoomOut()
    {
        if (!isZoomed)
            return;

        isZoomed = false;

        // Animate the camera zoom
        StartCoroutine(AnimateZoom(defaultFOV));
    }

    private IEnumerator AnimateZoom(float targetFOV)
    {
        float currentFOV = mainCamera.fieldOfView;

        while (Mathf.Abs(currentFOV - targetFOV) > 0.01f)
        {
            currentFOV = Mathf.Lerp(currentFOV, targetFOV, Time.deltaTime * zoomSpeed);
            mainCamera.fieldOfView = currentFOV;
            yield return null;
        }
    }
}