using UnityEngine;
using UnityEngine.InputSystem;

public class ShortcutPausePlayerMenu : MonoBehaviour
{
    public GameObject MenuPlayerPanel;
    public GameObject MenuPausePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!MenuPlayerPanel.activeInHierarchy && !MenuPausePanel.activeInHierarchy && Keyboard.current.semicolonKey.wasPressedThisFrame)
        {
            MenuPlayerPanel.SetActive(true);
        } else if(!MenuPausePanel.activeInHierarchy && !MenuPlayerPanel.activeInHierarchy && Keyboard.current.pKey.wasPressedThisFrame)
        {
            MenuPausePanel.SetActive(true);
        }
    }
}
