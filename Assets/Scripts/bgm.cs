using UnityEngine;

public class bgm : MonoBehaviour
{
    public AudioClip backgroundMusic;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.volume = 1f;  // Set the volume level as needed
        audioSource.Play();
    }
}
