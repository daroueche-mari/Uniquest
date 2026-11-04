using UnityEngine;
using UnityEngine.UI;

public class LinkNewGame : MonoBehaviour
{
    public Button NewGameBtn;
    public GameObject MainMenuPanel;
    public GameObject PreGamePanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewGameBtn.onClick.AddListener(LinkNewGameBtn);
    }

    // Update is called once per frame
    void Update()
    {

     }
    void LinkNewGameBtn()
    {
        MainMenuPanel.SetActive(false);
        PreGamePanel.SetActive(true);
    }
}
