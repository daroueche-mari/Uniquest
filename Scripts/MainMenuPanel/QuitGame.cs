using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button QuitBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        QuitBtn.onClick.AddListener(QuitGameAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void QuitGameAction()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
