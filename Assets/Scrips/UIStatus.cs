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
        int attackBonus = character.TotalAttack - character.BaseAttack;
        int defenseBonus = character.TotalDefense - character.BaseDefense;
        int criticalBonus = character.TotalCritical - character.BaseCritical;

        attackText.text = $"{character.TotalAttack} {(attackBonus > 0 ? $"(+{attackBonus})" : "")}";
        defenseText.text = $"{character.TotalDefense} {(defenseBonus > 0 ? $"(+{defenseBonus})" : "")}";
        healthText.text = $"{character.Health} / 100"; // 체력은 버프 아이템이 따로 없으니 고정
        criticalText.text = $"{character.TotalCritical}% {(criticalBonus > 0 ? $"(+{criticalBonus})" : "")}";
    }
}
