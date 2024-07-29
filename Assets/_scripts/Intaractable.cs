using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Intaractable : MonoBehaviour
{
   
    Outline outline;
    public string message;

    public UnityEvent onInteraction;
    void Start()
    {
        outline = GetComponent<Outline>();
        DisableOutline();
    }

    public void DisableOutline()
    {
        outline.enabled = false ;
    }

    public void EnabaleOutline()
    {
        outline.enabled = true ;    
    }

    public void Interact()
    {
        onInteraction.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
