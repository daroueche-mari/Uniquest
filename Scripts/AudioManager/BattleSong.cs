using UnityEngine;

public class BattleSong : MonoBehaviour
{

    public GameObject BattlePanel;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        StartMusic();
    }


    void StartMusic()
    {
        if (BattlePanel.activeInHierarchy && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if (!BattlePanel.activeInHierarchy && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
