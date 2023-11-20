using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] private TMP_Text level2, level3;

    private void Update()
    {
        ButtonController();
    }
    private void ButtonController()
    {
        if (PlayerPrefs.GetInt("Levels") < 2)
        {
            level2.GetComponent<Button>().enabled = false;
            level3.GetComponent<Button>().enabled = false;
        }
        else if (PlayerPrefs.GetInt("Levels") == 2)
        {
            level2.GetComponent<Button>().enabled = true;
            level3.GetComponent<Button>().enabled = false;
        }
        else if (PlayerPrefs.GetInt("Levels") >= 3)
        {
            level2.GetComponent<Button>().enabled = true;
            level3.GetComponent<Button>().enabled = true;
        }
    }
}
