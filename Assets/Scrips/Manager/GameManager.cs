using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        SetData();
    }

    // 캐릭터 생성 및 UI에 전달
    public void SetData()
    {
        List<Item> items = new List<Item>();
        items.Add(new Item(Resources.Load<ItemData>("Items/Sword")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Shield")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Hammer")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Bow")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Book")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Helmet")));
        items.Add(new Item(Resources.Load<ItemData>("Items/Bracelet")));

        Player = new Character("Rtan", 5, 3000, 30, 35, 100, 20, items);

        UIManager.Instance.Status.SetStatus(Player);
        UIManager.Instance.Inventory.InitInventoryUI();
    }
}
