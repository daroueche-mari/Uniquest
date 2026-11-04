using UnityEngine;
using UnityEngine.UI;

public class OpenMagicList : MonoBehaviour
{
    public GameObject MagicOption;
    public Button MagicBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MagicBtn.onClick.AddListener(MagicBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MagicBtnAction()
    {
        if (!MagicOption.activeInHierarchy)
        {
            MagicOption.SetActive(true);
        } else if (MagicOption.activeInHierarchy)
        {
            MagicOption.SetActive(false);
        }
    }
}
