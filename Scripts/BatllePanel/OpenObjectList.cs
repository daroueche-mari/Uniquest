using UnityEngine;
using UnityEngine.UI;

public class OpenObjectList : MonoBehaviour
{
    public GameObject ObjectOption;
    public Button ObjectBtn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObjectBtn.onClick.AddListener(ObjectBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObjectBtnAction()
    {
        if (!ObjectOption.activeInHierarchy)
        {
            ObjectOption.SetActive(true);

        } else if (ObjectOption.activeInHierarchy)
        {
            ObjectOption.SetActive(false);
        }
    }
}
