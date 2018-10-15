
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotObj : MonoBehaviour
{
    public float rotSpeed = 60;
    public float maxRotation = 22.5f;

    private void OnMouseDrag()
    {
        if (Input.mousePosition.y >= Screen.height || Input.mousePosition.y <= 0 || Input.mousePosition.x >= Screen.width || Input.mousePosition.x <= 0)
        {					
          return;
        }
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad * 10;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad * 5;


        // Debug.Log("Input.GetAxis(MOUSE X)" + Input.GetAxis("Mouse X"));
        // Debug.Log("Screen Width: " + Screen.width);
        transform.Rotate(Vector3.forward, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseDrag();
        };
    }
}