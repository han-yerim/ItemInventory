# 🔎Unity로 인벤토리 구현하기
캐릭터의 대기 화면 UI 시스템을 구현했습니다.

캐릭터 정보, 인벤토리, 장비 장착 등의 기능이 있으며 메인 메뉴 버튼UI를 통해서 UI 화면을 전환할 수 있습니다.

## 🏰메인 메뉴
![main](https://github.com/user-attachments/assets/5afeb526-a8df-44f1-9c4e-683ef6fabce6)

플레이어 캐릭터의 아이디, 레벨, 골드 정보가 표시되어 있습니다.

Status, Inventory 버튼을 누르면 해당 UI 정보가 열립니다.

## ⛹️‍♂️캐릭터 정보(Status)
![status](https://github.com/user-attachments/assets/f455d804-0bdd-40e4-bc45-1cf4556476be)

캐릭터의 공격력, 방어력, 체력, 치명타 수치 확인이 가능합니다.

장착 아이템에 따른 고유 능력치 스탯 변동도 바로 반영됩니다.

## 💼인벤토리(Inventory)
![Inventory](https://github.com/user-attachments/assets/aff2cfd5-33b6-4965-824e-b5a57099469a)

아이템 리스트가 한눈에 보이게 표시되어 있습니다.

슬롯을 클릭하면 장착/해제 유무를 알려주는 'E' 아이콘이 표시됩니다.

같은 타입의 장비는 중복 착용이 불가능합니다. (무기/ 방어구 각 1개씩만 착용 가능, 무기와 방어구 1개씩은 OK)

## ⚙기능 소개

| 스크립트             | 설명 |
|------------------|------|
| **UIManager**     | UI 전환 및 싱글톤 관리 |
| **UIMainMenu**    | 메인 메뉴 UI 제어 |
| **UIStatus**      | 캐릭터 스탯 UI 표시 |
| **UIInventory**   | 인벤토리 UI 표시 및 슬롯 초기화 |
| **UISlot**        | 개별 아이템 슬롯, 클릭 시 장착 로직 |
| **Character**     | 캐릭터 데이터 (닉네임, 능력치, 장비 목록 등) |
| **ItemData**      | ScriptableObject로 아이템 정보 저장 |
| **Item**          | 인벤토리에 들어가는 아이템 개체화 (장착 여부 포함) |
| **GameManager**   | 초기 데이터 세팅 및 UI 연결 |

### 👩‍💻제작
한예림
