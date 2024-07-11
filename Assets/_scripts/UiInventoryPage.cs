using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiInventoryPage : MonoBehaviour
{

    [SerializeField] private UiInvenoryItem itemPrefab;

    [SerializeField]
    private RectTransform contentPanel;

    List<UiInvenoryItem> ListOfItems = new List<UiInvenoryItem>();

    public void InitializedInventory(int inventorysize)
    {
        for (int i = 0; i < inventorysize; i++)
        {
            UiInvenoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            ListOfItems.Add(uiItem);
        }
    }
}
