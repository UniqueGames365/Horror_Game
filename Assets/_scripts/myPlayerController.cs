using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayerController : MonoBehaviour
{

    public float playerReach = 3f;
    Intaractable currentNtractable;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && currentNtractable != null)
        {
            currentNtractable.Interact();
        }
    }

    void CheckIntacrion()
    {
        RaycastHit hit;
        Ray ray= new Ray(Camera.main.transform.position,Camera.main.transform.forward);
        if(Physics.Raycast(ray, out hit,playerReach))
        {
            if(hit.collider.tag=="Intractable")
            {

            }
        }
    }
}
