using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // Ensure the cursor is visible and not locked at the start
        Cursor.visible = true;
       Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        // Check if the cursor should be visible and not locked during gameplay
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle cursor visibility and lock state with the Escape key
            Debug.Log("escape");
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = Cursor.visible ? CursorLockMode.None : CursorLockMode.Locked;
        }

        // Ensure the cursor is always visible and not locked
        if (!Cursor.visible || Cursor.lockState != CursorLockMode.None)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
