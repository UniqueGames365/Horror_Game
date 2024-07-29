using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiInvenoryItem : MonoBehaviour
{
    public static UiInvenoryItem Instance;
    public  int appleCount=0;
    public  int chemOneCount;

    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
        if(appleCount!=0)
            Debug.Log(appleCount);
        else if (chemOneCount != 0)
            Debug.Log(chemOneCount);
            
    }
}
