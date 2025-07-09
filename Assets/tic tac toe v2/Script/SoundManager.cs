using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource clickSound;
    public AudioSource winSound;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayClick()
    {
        clickSound.Play();
    }

    public void PlayWin()
    {
        winSound.Play();
    }
}


