using UnityEngine;
using UnityEngine.UI;

public class QuitFromGame : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject MenuPausePanel;
    public GameObject MainMenuPanel;
    public Button SaveAndQuitBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SaveAndQuitBtn.onClick.AddListener(SaveQuitBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SaveQuitBtnAction()
    {
        // Save part at added here
        if (GamePanel.activeInHierarchy && MenuPausePanel.activeInHierarchy)
        GamePanel.SetActive(false);
        MenuPausePanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
}
