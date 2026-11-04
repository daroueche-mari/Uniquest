using UnityEngine;
using UnityEngine.UI;

public class ToBattlePanelBtn : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject BattlePanel;
    public Button TestBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestBtn.onClick.AddListener(TestBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestBtnAction()
    {
        if(GamePanel.activeInHierarchy && !BattlePanel.activeInHierarchy)
        {
            GamePanel.SetActive(false);
            BattlePanel.SetActive(true);
        }
        
    }
}
