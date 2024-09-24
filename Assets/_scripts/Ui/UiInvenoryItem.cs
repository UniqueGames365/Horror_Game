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
    public  int chemOneCount=0;
    [SerializeField] private List<TMP_Text> colectableCountTexts; 

    private void Start()
    {
        Instance = this;
    }

    private void Update()
    {
   
         colectableCountTexts[0].text = appleCount.ToString();
            colectableCountTexts[1].text = chemOneCount.ToString();

    }
}
