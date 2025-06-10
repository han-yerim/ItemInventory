using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI attackText;
    [SerializeField] private TextMeshProUGUI defenseText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI criticalText;

    [SerializeField] private Button backBtn;

    public Button BackBtn => backBtn;

    public void Start()
    {
        backBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    public void SetStatus(Character character)
    {
        attackText.text = character.Attack.ToString();
        defenseText.text = character.Defense.ToString();
        healthText.text = $"{character.Health} / 100";
        criticalText.text = $"{character.Critical}%";
    }
}
