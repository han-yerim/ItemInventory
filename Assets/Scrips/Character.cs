using System.Collections;
using System.Collections.Generic;
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

    public void Equip(Item item)
    {
        item.Equip();
    }

    public void UnEquip(Item item)
    {
        item.UnEquip();
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
