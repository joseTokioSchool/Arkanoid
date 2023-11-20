using UnityEngine;

public class Level3Fix : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("Levels") <= 3)
        {
            PlayerPrefs.SetInt("Levels", 4);
        }
    }
}
