using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private Image equippedCheck;

    private ItemData _itemData;
    private bool _isEquipped;

    public void SetItem(ItemData data, bool isEquipped = false)
    {
        _itemData = data;
        _isEquipped = isEquipped;
        Debug.Log($"SetItem 호출됨: {_itemData?.itemName}");
        RefreshUI();
    }

    public void RefreshUI()
    {
        Debug.Log("RefreshUI 호출됨");

        if (_itemData == null)
        {
            itemIcon.enabled = false;
            equippedCheck.gameObject.SetActive(false);
            return;
        }
        else
        {
            itemIcon.enabled = true;
            itemIcon.sprite = _itemData.itemIcon;

            Debug.Log($"아이콘 적용: {itemIcon.sprite.name}");

            equippedCheck.gameObject.SetActive(_isEquipped);
        }
    }

    private void Start()
    {
        // 클릭 시 장착/해제
        GetComponent<Button>().onClick.AddListener(ToggleEquip);
    }

    private void ToggleEquip()
    {
        if (_itemData == null) return;

        _isEquipped = !_isEquipped;
        equippedCheck.gameObject.SetActive(_isEquipped);
        Debug.Log($"{_itemData.itemName} 장착 상태: {_isEquipped}");
    }
}
