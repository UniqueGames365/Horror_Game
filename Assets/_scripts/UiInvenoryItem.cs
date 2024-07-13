using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiInvenoryItem : MonoBehaviour
{

    [SerializeField]private  Image itemImage;

    [SerializeField] private TMP_Text quantityText;
    [SerializeField]
    private Image boderImage;

    public event Action<UiInvenoryItem> OnItemClicked,OnItemDroppedOn,OnItemBeginDrag,OnItemEndDrag,OnRightMouseBtnCliked;

    private bool emplty= true;

    public void Awake()
    {
        ResetData();
        Deselect();
    }

    public void ResetData()
    {
        this.itemImage.gameObject.SetActive(false);
        emplty= true;
    }

    public void Deselect()
    {
        boderImage.enabled = false;
    }

    public void SetData(Sprite sprite, int quantity)
    {
        this.itemImage.gameObject.SetActive (true);
        this.itemImage.sprite = sprite;
        this.quantityText.text = quantity + "";
        emplty= false;
    }

    public void Select()
    {
        boderImage.enabled= true;
    }

    public void OnBeginDrag()
    {
        if(emplty)
        {
            return;
        }
        OnItemBeginDrag? .Invoke(this);
    }

    public void OnDrop()
    {
        OnItemDroppedOn?.Invoke(this);
    }

    public void OnEndDrag()
    {
        OnItemEndDrag?.Invoke(this);
    }

    public void OnPointerCliked(BaseEventData data)
    {
        if (emplty)
        {
            return;
        }
        PointerEventData pointerData = (PointerEventData)data;
        if (pointerData.button == PointerEventData.InputButton.Right)
        {
            OnRightMouseBtnCliked?.Invoke(this);
        }
        else
        {
            OnItemClicked?.Invoke(this);
        }
    }
}
