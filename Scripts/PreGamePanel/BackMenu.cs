using UnityEngine;
using UnityEngine.UI;

public class BackMenu : MonoBehaviour
{
    public Button BackMenuBtn;
    public GameObject PreGamePanel;
    public GameObject MainMenuPanel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BackMenuBtn.onClick.AddListener(BackMenuAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackMenuAction()
    {
        PreGamePanel.SetActive(false);
        MainMenuPanel.SetActive(true);
    }
}
