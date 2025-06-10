using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemData Data { get; private set; }
    public bool IsEquipped { get; private set; }

    public Item(ItemData data)
    {
        Data = data;
        IsEquipped = false;
    }

    public void Equip()
    {
        IsEquipped = true;
    }

    public void UnEquip()
    {
        IsEquipped = false;
    }
}
