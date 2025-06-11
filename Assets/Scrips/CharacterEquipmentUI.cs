using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterEquipmentUI : MonoBehaviour
{
    // 아이템 이미지 오브젝트
    [SerializeField] private GameObject swordObj;
    [SerializeField] private GameObject shieldObj;
    [SerializeField] private GameObject necklaceObj;
    [SerializeField] private GameObject helmetObj;
    [SerializeField] private GameObject hammerObj;
    [SerializeField] private GameObject bowObj;
    [SerializeField] private GameObject bookObj;

    public void UpdateVisuals(Character character) // 장착 여부 확인
    {
        bool hasSword = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Sword");
        swordObj.SetActive(hasSword);

        bool hasShield = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Shield");
        shieldObj.SetActive(hasShield);

        bool hasNecklace = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Necklace");
        necklaceObj.SetActive(hasNecklace);

        bool hasHelmet = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Helmet");
        helmetObj.SetActive(hasHelmet);

        bool hasHammer = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Hammer");
        hammerObj.SetActive(hasHammer);

        bool hasBow = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Bow");
        bowObj.SetActive(hasBow);

        bool hasBook = character.Inventory.Exists(i => i.IsEquipped && i.Data.itemName == "Book");
        bookObj.SetActive(hasBook);
    }
}
