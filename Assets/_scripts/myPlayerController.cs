using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class myPlayerController : MonoBehaviour
{

    public float playerReach = 3f;
    Intaractable currentNtractable;
    public string message;
    // Update is called once per frame
    void Update()
    {
        CheckIntacrion();
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
                Intaractable newInteractable= hit.collider.GetComponent<Intaractable>();

                if( currentNtractable &&  newInteractable != currentNtractable )
                {
                    currentNtractable.DisableOutline();
                }
                if(newInteractable.enabled)
                {
                    setNewCurrentIntactable(newInteractable);
                }
                else
                {
                    disableCurrentIntractable();
                }
            }
            else
            {
                disableCurrentIntractable();
            }
        }

        else
        {
            disableCurrentIntractable();
        }
    }

    private void setNewCurrentIntactable(Intaractable newInteractable)
    {
      currentNtractable = newInteractable;
        currentNtractable.EnableOutline();
        Hud_controller.instance.enebleIntraction(currentNtractable.message);
    }

    private void disableCurrentIntractable()
    {
        Hud_controller.instance.disableIntraction();
        if (currentNtractable)
        {
            currentNtractable.DisableOutline();
            currentNtractable = null;
        }
    }
}
