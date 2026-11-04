using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button LetsGoBtn;
    public GameObject PreGamePanel;
    public GameObject GamePanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LetsGoBtn.onClick.AddListener(StartGameAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGameAction()
    {
        PreGamePanel.SetActive(false);
        GamePanel.SetActive(true);
    }
}
