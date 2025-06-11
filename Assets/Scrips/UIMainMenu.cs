using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text nicknameText;
    [SerializeField] private TMP_Text levelText;
    [SerializeField] private TMP_Text goldText;

    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    public void SetCharacter(Character character)
    {
        nicknameText.text = character.Nickname;
        levelText.text = $"LV {character.Level}";
        goldText.text = $"{character.Gold:N0}";
    }

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }
    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }

    public void OpenStatus()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
    }

    public void OpenInventory()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
    }
}
