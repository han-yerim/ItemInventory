using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemIcon;
    [SerializeField] private Image equippedCheck;

    private ItemData _item;
    private bool _isEquipped;

    public void SetItem(ItemData item, bool isEquipped = false)
    {
        _item = item;
        _isEquipped = isEquipped;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (_item == null)
        {
            itemIcon.enabled = false;
            equippedCheck.gameObject.SetActive(false);
        }
        else
        {
            itemIcon.sprite = _item.itemIcon;
            itemIcon.enabled = true;
            equippedCheck.gameObject.SetActive(_isEquipped);
        }
    }
}
