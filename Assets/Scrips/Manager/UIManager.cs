using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("UI 연결")]
    [SerializeField] private UIMainMenu _mainMenu;
    [SerializeField] private UIStatus _statusUI;
    [SerializeField] private UIInventory _inventoryUI;

    //읽기 전용 프로퍼티
    public UIMainMenu MainMenu => _mainMenu;
    public UIStatus Status => _statusUI;
    public UIInventory Inventory => _inventoryUI;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
}
