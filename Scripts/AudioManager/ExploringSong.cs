using UnityEngine;

public class ExploringSong : MonoBehaviour
{

    public GameObject GamePanel;
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
        if (GamePanel.activeInHierarchy && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        else if (!GamePanel.activeInHierarchy && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
