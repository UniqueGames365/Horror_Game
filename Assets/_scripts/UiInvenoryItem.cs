using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiInvenoryItem : MonoBehaviour
{

    private List<IColectableObserver> colectableObservers = new List<IColectableObserver>();

    private void Start()
    {
        // Add initial observers if needed
    }

    private void Update()
    {
        // Update logic if needed
    }

    public void RegisterObserver(IColectableObserver observer)
    {
        if (!colectableObservers.Contains(observer))
        {
            colectableObservers.Add(observer);
        }
    }

    public void UnregisterObserver(IColectableObserver observer)
    {
        if (colectableObservers.Contains(observer))
        {
            colectableObservers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        foreach (var observer in colectableObservers)
        {
            Debug.Log("Notifying observer");
            observer.OnDisable();
        }
    }
}
