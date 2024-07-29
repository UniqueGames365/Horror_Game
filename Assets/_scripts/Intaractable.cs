using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Intaractable : MonoBehaviour, IColectableObserver
{
    Outline outline;
    public string message;
    public CollectableItem _collectableItem;

    public UnityEvent onInteraction;

    private UiInvenoryItem uiInventoryItem;

    void Start()
    {
        outline = GetComponent<Outline>();
        DisableOutline();
    }

    public void SetUiInventoryItem(UiInvenoryItem inventoryItem)
    {
        uiInventoryItem = inventoryItem;
    }

    public void DisableOutline()
    {
        outline.enabled = false;
    }

    public void EnableOutline()
    {
        outline.enabled = true;
    }

    public void Interact()
    {
        onInteraction.Invoke();
    }

    void Update()
    {

    }

    public void OnDisable()
    {
        Debug.Log("disabled");
        DisableItem();
    }

    public void DisableItem()
    {
        // Perform your disable logic here
        //OnDisable();
        if (uiInventoryItem != null)
        {
            uiInventoryItem.NotifyObservers();
        }
    }
}
