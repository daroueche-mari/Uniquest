using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class AbandoneChoice : MonoBehaviour
{
    public GameObject BattlePanel;
    public GameObject GamePanel;
    public GameObject AttackOption;
    public GameObject MagicOption;
    public GameObject ObjectOption;
    public Button AbandoneBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AbandoneBtn.onClick.AddListener(AbandoneBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AbandoneBtnAction()
    {
       EditorUtility.DisplayDialog("Defeat", "You have been defeated!", "OK");
        // You can add other logic here related to the defeat of the player
        if (BattlePanel.activeInHierarchy && !GamePanel.activeInHierarchy)
        {
            AttackOption.SetActive(false);
            MagicOption.SetActive(false);
            ObjectOption.SetActive(false);
            BattlePanel.SetActive(false);
            GamePanel.SetActive(true);
        }
    }
}
