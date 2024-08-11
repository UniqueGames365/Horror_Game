using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class torchController : MonoBehaviour
{
    public Camera mainCamera; // Reference to the main camera

    void Start()
    {
        // If the camera isn't assigned in the Inspector, find the main camera
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        // Get the screen midpoint
        Vector3 screenMidpoint = new Vector3(Screen.width / 2, Screen.height / 2, 0);

        // Convert the screen midpoint to a world position
        Ray ray = mainCamera.ScreenPointToRay(screenMidpoint);

        // Rotate the torch to follow the direction of the ray
        transform.up =ray.direction;
    }
}
