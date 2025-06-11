using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct ItemStat
{
    public int AttackBonus;
    public int DefenseBonus;
    public float CriticalBonus;
}

public class Item
{
    public ItemData Data { get; private set; }

    public bool IsEquipped { get; private set; }

    public ItemStat Stat => new ItemStat
    {
        AttackBonus = Data != null ? Data.attackBonus : 0,
        DefenseBonus = Data != null ? Data.defenseBonus : 0,
        CriticalBonus = Data != null ? Data.criticalBonus : 0
    };
    public Item(ItemData data)
    {
        Data = data;
        IsEquipped = false;
    }

    // 장착 관련 메서드
    public void Equip() => IsEquipped = true;
    public void UnEquip() => IsEquipped = false;
}
