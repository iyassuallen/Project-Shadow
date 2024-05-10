using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("Sources")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Clips")]
    public AudioClip background;
    public AudioClip walk;
    public AudioClip jump;
    public AudioClip land;

    public void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySound(AudioClip clip)
    {
        if (sfxSource.isPlaying && clip == walk)
        {
            return;
        }
        sfxSource.PlayOneShot(clip);
    }

    public void StopSound()
    {
        sfxSource.Stop();
    }
}
