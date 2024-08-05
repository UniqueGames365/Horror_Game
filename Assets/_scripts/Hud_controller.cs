using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hud_controller : MonoBehaviour
{
   public static Hud_controller instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] private TMP_Text interactionText;

    public void enebleIntraction( string text)
    {
        interactionText.text = text+ "(F)";
        interactionText.gameObject.SetActive(true);
    }

    public void disableIntraction()
    {
        interactionText.gameObject.SetActive(false);
    }
}
