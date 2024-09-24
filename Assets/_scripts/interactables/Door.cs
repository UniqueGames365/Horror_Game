using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    private Vector3 openRotation= new Vector3 (0,90,0);
    private float rotationSpeed = 1.0f;
    private Quaternion closedRotation;// save original rotation
    private Quaternion TargetRotation;
    public UnityEvent OnDoorOpen;
    bool isOpen= false;
    bool triggerZone= false;
    void Start()
    {
        //save closed rotation
        closedRotation = transform.rotation;
        //set the target rotaion when closing door need
        TargetRotation = closedRotation;
    }

 
    void Update()
    {
     if(triggerZone && Input.GetKeyDown(KeyCode.E))
        {
            ToggleDoor();
        }   
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Detector"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;
            }
        }
        transform.rotation= Quaternion.Slerp(transform.rotation,TargetRotation, Time.deltaTime*rotationSpeed);
    }

    public void ToggleDoor()
    {
        OnDoorOpen.Invoke();
       if(isOpen)
        {
            //Open then closed it 
            TargetRotation= closedRotation;
        }
       else
        {
            //if door cloed it open using 
            TargetRotation = Quaternion.Euler(openRotation) * closedRotation;
        }
       isOpen= !isOpen;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Detector"))
        {
            triggerZone = true;
            Debug.Log("Enter TriggerZone");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Detector"))
        {
            triggerZone = false;
            Debug.Log("Exit TriggerZone");

        }
    }

}
