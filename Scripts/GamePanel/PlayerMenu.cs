using UnityEngine;
using UnityEngine.UI;

public class PlayerMenu : MonoBehaviour
{
    public Button PlayerMenuBtn;
    public GameObject MenuPlayerPanel;
    public GameObject MenuPausePanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMenuBtn.onClick.AddListener(PlayerMenuAction);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerMenuAction()
    {
        if(!MenuPlayerPanel.activeInHierarchy && !MenuPausePanel.activeInHierarchy)
        {
            MenuPlayerPanel.SetActive(true);
        }
        
    }
    
}
