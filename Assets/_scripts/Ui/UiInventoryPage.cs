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
    private AudioSource Audiosorce;
    [SerializeField] private Image _itemImage;
    [SerializeField] private CollectableItem _CollectableItem;

    [SerializeField] public GameObject[] _leftHandItems;

    private void Start()
    {
        for (int i = 0; i < _leftHandItems.Length; i++)
        {
            _leftHandItems[i].SetActive(false);
        }
    }

    public void clicked(int index)
    {
        
        _itemImage.sprite=_CollectableItem.itemIcon;
        Name.text =_CollectableItem.name;
        description.text = _CollectableItem.description;

        switch (index)
        {
            case 0:
                myPlayerController.instance.getHelathPack();
                break;

            case 1:
                _leftHandItems[0].SetActive(true);
                aciveSelection(0);
                break;
            case 2:
                _leftHandItems[1].SetActive(true);
                aciveSelection(1);
                break;

        }
     
    }

    private void aciveSelection(int selectedInedx)
    {
        for (int i = 0; i < _leftHandItems.Length; i++)
        {
            if (i == selectedInedx)
            {
                continue;
            }

            _leftHandItems[i].SetActive(false);
        }
    }
}
