using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /*--------------------------------------------------- SINGLETONS --------------------------------------------------- */
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    /*------------------------------------------------------------------------------------------------------------------ */

    /*---------------------------------- VARIABLES ----------------------------------*/
    [SerializeField] GameObject gameoverPanel;

    private int blocksLeft;
    private void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Brick").Length;
    }

    /*---------------------------------- Para acabar la partida.----------------------------------*/
    public void GameOver()
    {
        Time.timeScale = 0f;
        gameoverPanel.SetActive(true);
    }
    /*---------------------------------- Para reiniciar la partida.----------------------------------*/
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    /*---------------------------------- Para pasar al siguiente nivel.----------------------------------*/
    public void BlockDestroyed()
    {
        blocksLeft--;
        if (blocksLeft <= 0)
        {
            LevelManager();
            LoadLevel();
        }
    }
    public void LoadLevel()
    {
        if (PlayerPrefs.GetInt("Levels") <= 1)
        {
            SceneManager.LoadScene(1);
        }
        else if (PlayerPrefs.GetInt("Levels") == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (PlayerPrefs.GetInt("Levels") == 3)
        {
            SceneManager.LoadScene(3);
        }
        else if (PlayerPrefs.GetInt("Levels") >= 4)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void LevelManager()
    {
        if (PlayerPrefs.GetInt("Levels") < 2)
        {
            PlayerPrefs.SetInt("Levels", 2);
        }
        else if (PlayerPrefs.GetInt("Levels") == 2)
        {
            PlayerPrefs.SetInt("Levels", 3);
        }
        else if (PlayerPrefs.GetInt("Levels") >= 3)
        {
            PlayerPrefs.SetInt("Levels", 4);
        }
    }

    /*---------------------------------- Para ir al Menú Principal.----------------------------------*/
    public void MainMenu(int n)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(n);
    }
}
