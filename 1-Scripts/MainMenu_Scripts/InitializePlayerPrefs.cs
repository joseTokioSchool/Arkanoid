using UnityEngine;

public class InitializePlayerPrefs : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Levels") == false)
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
    }
}
