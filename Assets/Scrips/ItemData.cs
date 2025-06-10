using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Armor
}

[CreateAssetMenu(fileName = "NewItem", menuName = "Item/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public ItemType itemType;
}
