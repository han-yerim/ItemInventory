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
    private void InitInventoryUI()
    {
        int slotCount = 30; // 슬롯 개수

        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(_slotPrefab, _slotParent);
            newSlot.SetItem(null, 0); // 초기 상태
            _slots.Add(newSlot);
        }
    }

    // 슬롯 외부 접근용 메서드
    public void UpdateSlot(int index, ItemData item, int count)
    {
        if (index >= 0 && index < _slots.Count)
        {
            _slots[index].SetItem(item, count);
        }
    }
}
