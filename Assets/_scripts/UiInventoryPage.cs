using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiInventoryPage : MonoBehaviour
{
    public TMP_Text description;
    public TMP_Text Name;
    [SerializeField] private Image _itemImage;
    [SerializeField] private CollectableItem _CollectableItem;
    public void clicked()
    {
        _itemImage.sprite=_CollectableItem.itemIcon;
        Name.text =_CollectableItem.name;
        description.text = _CollectableItem.description;
     //   Debug.Log("clevkewd");
    }
    
}
