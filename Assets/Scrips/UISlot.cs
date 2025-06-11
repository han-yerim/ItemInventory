using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        RefreshUI();
    }

    public void RefreshUI()
    {

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

        var character = GameManager.Instance.Player;

        if (character.Inventory.FirstOrDefault(i => i.Data == _itemData)?.IsEquipped == true)
        {
            character.UnEquip(_itemData);
        }
        else
        {
            character.Equip(_itemData);
        }

        // UI 갱신
        UIManager.Instance.Inventory.InitInventoryUI();
        equippedCheck.gameObject.SetActive(_isEquipped);
    }
}
