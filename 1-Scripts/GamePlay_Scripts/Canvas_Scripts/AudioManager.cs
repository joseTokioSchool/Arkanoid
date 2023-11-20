using UnityEngine;

public class AudioManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    public static AudioManager AudioInstance { get; private set; }

    private void Awake()
    {
        if (AudioInstance != null && AudioInstance != this)
        {
            Destroy(this);
        }
        else
        {
            AudioInstance = this;
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource musicSource;

    [Header("Canvas")]
    [SerializeField] AudioClip gameOverClip;
    [SerializeField] AudioClip pauseClip;

    [Header("Player")]
    [SerializeField] AudioClip paddleHitClip;

    [Header("Items")]
    [SerializeField] AudioClip brickHitClip;
    //[SerializeField] AudioClip powerUpClip;

    public void GameOverClip()
    {
        audioSource.PlayOneShot(gameOverClip);
    }
    public void PauseClip()
    {
        audioSource.PlayOneShot(pauseClip);
    }
    public void PaddleHitClip()
    {
        audioSource.PlayOneShot(paddleHitClip);
    }
    public void BrickHitClip()
    {
        audioSource.PlayOneShot(brickHitClip);
    }
    //public void PowerUpClip()
    //{
    //    audioSource.PlayOneShot(powerUpClip);
    //}
}
