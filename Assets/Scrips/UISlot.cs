using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _countText;

    private ItemData _item;
    private int _count;

    public void SetItem(ItemData item, int count)
    {
        _item = item;
        _count = count;
        RefreshUI();
    }

    public void RefreshUI()
    {
        if (_item != null)
        {
            _icon.sprite = _item.itemIcon;
            _icon.enabled = true;
        }
        else
        {
            _icon.sprite = null;
            _icon.enabled = false;
            _countText.text = "";
        }
    }
}
