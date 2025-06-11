using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string Nickname { get; private set; }
    public int Level { get; private set; }
    public int Gold { get; private set; }

    public float Health { get; private set; }
    public int BaseAttack { get; private set; }
    public int BaseDefense { get; private set; }
    public int BaseCritical { get; private set; }

    public List<Item> Inventory { get; private set; }

    public Character(string nickname, int level, int gold, float health, int attack, int defense, int critical, List<Item> inventory)
    {
        Nickname = nickname;
        Level = level;
        Gold = gold;
        Health = health;
        BaseAttack = attack;
        BaseDefense = defense;
        BaseCritical = critical;
        Inventory = inventory;
    }

    public int TotalAttack => BaseAttack + GetBonus(ItemType.Weapon, stat => stat.AttackBonus);
    public int TotalDefense => BaseDefense + GetBonus(ItemType.Armor, stat => stat.DefenseBonus);
    public int TotalCritical => BaseCritical + GetBonus(ItemType.Weapon, stat => (int)stat.CriticalBonus);

    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    public void Equip(ItemData data) // 아이템 장착시
    {

        Item currentItem = Inventory.FirstOrDefault(i => i.Data == data);
        if (currentItem != null && currentItem.IsEquipped) return;

        // 같은 타입의 장비가 장착되어 있으면 해제
        foreach (var item in Inventory)
        {
            if (item.IsEquipped && item.Data.itemType == data.itemType)
            {
                item.UnEquip();
            }
        }

        currentItem?.Equip();
        UIManager.Instance.Status.SetStatus(this); // 스탯 UI 업데이트
        UIManager.Instance.EquipmentUI.UpdateVisuals(this); // 장착시 아이템 이미지 활성화
    }

    public void UnEquip(ItemData data) // 아이템 해제시
    {
        Item item = Inventory.FirstOrDefault(i => i.Data == data);
        if (item != null && item.IsEquipped)
        {
            item.UnEquip();
            UIManager.Instance.Status.SetStatus(this);
        }

        UIManager.Instance.EquipmentUI.UpdateVisuals(this); // 장착 해제시 이미지 비활성화
    }

    private int GetBonus(ItemType type, System.Func<ItemStat, int> selector)
    {
        int sum = 0;
        foreach (var item in Inventory)
        {
            if (item.IsEquipped && item.Data.itemType == type)
            {
                sum += selector(item.Stat);
            }
        }
        return sum;
    }
}
