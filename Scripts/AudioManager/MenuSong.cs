using UnityEngine;

public class MenuSong : MonoBehaviour
{

    public GameObject MainMenuPanel;
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
        if(MainMenuPanel.activeInHierarchy && !audioSource.isPlaying)
        {
            audioSource.Play();
        } else if(!MainMenuPanel.activeInHierarchy && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
