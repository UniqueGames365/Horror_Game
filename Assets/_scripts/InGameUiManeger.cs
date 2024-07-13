using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUiManeger : MonoBehaviour
{
    [SerializeField] private GameObject InvetoryPanal;
    private bool isEnable=false;

    [SerializeField] private UiInventoryPage invetoryUI;

    private int inventoySize = 10;

    void Start()
    {
        
        InvetoryPanal.SetActive(false);
            invetoryUI.InitializedInventory(inventoySize);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            isEnable= !isEnable;
            InvetoryPanal.SetActive(isEnable);

        }
    }
}
