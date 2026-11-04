using UnityEngine;
using UnityEngine.UI;

public class BackGameFromPause : MonoBehaviour
{
    public Button ResumeBtn;
    public GameObject MenuPausePanel;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResumeBtn.onClick.AddListener(ResumeBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResumeBtnAction()
    {
        if (MenuPausePanel.activeInHierarchy)
        {
            MenuPausePanel.SetActive(false);
        }
    }
}
