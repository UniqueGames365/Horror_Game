using UnityEngine;

[CreateAssetMenu(fileName = "New Collectable Item", menuName = "Collectable Item/Food")]
public class CollectableItem : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public int itemValue;
    public GameObject itemPrefab;
    // Add other properties as needed
}
