using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    // 슬롯 연결
    [SerializeField] private UISlot _slotPrefab;
    [SerializeField] private Transform _slotParent;
    // 뒤로가기 버튼
    [SerializeField] private Button backBtn;

    private List<UISlot> _slots = new List<UISlot>();

    public Button BackBtn => backBtn;

    private void Start()
    {
        InitInventoryUI();
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    // 슬롯 초기화
    public void InitInventoryUI()
    {
        var items = GameManager.Instance.Player.Inventory;
        int slotCount = 30; // 슬롯 개수

        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(_slotPrefab, _slotParent);

            // 인벤토리에 아이템이 있으면 할당, 없으면 null
            if (items != null && i < items.Count)
                newSlot.SetItem(items[i].Data, items[i].IsEquipped);
            else
                newSlot.SetItem(null, false);

            _slots.Add(newSlot);
        }
    }
}
