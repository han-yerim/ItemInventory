using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    // 캐릭터 생성 및 UI에 전달
    public void SetData()
    {
        Player = new Character("Rtan", 1, 3000, 35, 40, 100, 25f);

        UIManager.Instance.MainMenu.SetCharacter(Player);
        UIManager.Instance.Status.SetStatus(Player);
    }
}
