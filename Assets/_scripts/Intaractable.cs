using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ItemType
{
    Health,
    ChemicalOne
}

public class Intaractable : MonoBehaviour
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

    void OnDisable()
    {
    
        if (_collectableItem.itemName == ItemType.Health.ToString())
        {
            UiInvenoryItem.Instance.appleCount++;
        }
        else if(_collectableItem.itemName== ItemType.ChemicalOne.ToString())
        {
            UiInvenoryItem.Instance.chemOneCount++;
        }
    }
}
