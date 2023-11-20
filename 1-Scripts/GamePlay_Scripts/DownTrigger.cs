using UnityEngine;

public class DownTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.GameOver();
        AudioManager.AudioInstance.GameOverClip();
    }
}
