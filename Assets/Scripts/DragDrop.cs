using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging;
    private Vector3 initialMousePosition;
    private Vector3 initialObjectPosition;
    

    public void OnMouseDown()
    {
        isDragging = true;
        initialMousePosition = GetMouseWorldPosition();
        initialObjectPosition = transform.position;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 currentMousePosition = GetMouseWorldPosition();
            Vector3 offset = (currentMousePosition - initialMousePosition);
            transform.position = initialObjectPosition + offset;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}