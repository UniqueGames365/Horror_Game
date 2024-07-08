using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUiManeger : MonoBehaviour
{
    [SerializeField] private GameObject InvetoryPanal;
    private bool isEnable=false;
    void Start()
    {
        
        InvetoryPanal.SetActive(false);
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
