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
        // 씬에 있는 슬롯만 찾아서 리스트에 추가
        _slots.Clear();
        foreach (Transform child in _slotParent)
        {
            UISlot slot = child.GetComponent<UISlot>();
            if (slot != null)
                _slots.Add(slot);
        }
        InitInventoryUI();
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    // 슬롯 초기화
    public void InitInventoryUI()
    {
        var items = GameManager.Instance.Player.Inventory;

        for (int i = 0; i < _slots.Count; i++)
        {
            if (items != null && i < items.Count)
                _slots[i].SetItem(items[i].Data, items[i].IsEquipped);
            else
                _slots[i].SetItem(null, false);
        }
    }
}
