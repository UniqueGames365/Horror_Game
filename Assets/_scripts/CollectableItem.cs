using UnityEngine;

[CreateAssetMenu(fileName = "New Collectable Item", menuName = "Collectable Item")]
public class CollectableItem : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public int itemValue;
    public GameObject itemPrefab;
    public string description;
    public AudioClip AudioClip;
    // Add other properties as needed
}
