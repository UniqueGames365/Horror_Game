using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Collectable Item", menuName = "Collectable Item/items")]
public class CollectableItem : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    //public string name;
    public string description;
    public GameObject itemPrefab;
    // Add other properties as needed
}
