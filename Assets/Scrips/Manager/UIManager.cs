using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [SerializeField] private UIMainMenu _mainMenu;
    [SerializeField] private UIStatus _status;
    [SerializeField] private UIInventory _inventory;

    //읽기 전용 프로퍼티
    public UIMainMenu MainMenu => _mainMenu;
    public UIStatus Status => _status;
    public UIInventory Inventory => _inventory;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        GameManager.Instance.SetData(); // 캐릭터 데이터 불러오기
    }
}
