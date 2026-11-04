using UnityEngine;
using UnityEngine.UI;

public class OpenAttackList : MonoBehaviour
{
    public GameObject AttackOption;
    public Button AttackBtn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackBtn.onClick.AddListener(AttackBtnAction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AttackBtnAction()
    {
        if (!AttackOption.activeInHierarchy)
        {
            AttackOption.SetActive(true);
        } else if (AttackOption.activeInHierarchy)
        {
            AttackOption.SetActive(false);
        }
        
    } 
}
