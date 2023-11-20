using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void ChangeScene(int n)
    {
        SceneManager.LoadScene(n);
    }
    public void ExitGame()
    {
        //Debug.Log(PlayerPrefs.GetInt("Levels")); // TEST
        Application.Quit();
    }
    public void NewGame()
    {
        PlayerPrefs.DeleteAll();
    }
    /*------------------ FUNCIONES PARA TESTEAR ------------------*/
    public void Test1()
    {
        PlayerPrefs.SetInt("Levels", 2);
        Debug.Log(PlayerPrefs.GetInt("Levels"));
    }
    public void Test2()
    {
        PlayerPrefs.SetInt("Levels", 3);
        Debug.Log(PlayerPrefs.GetInt("Levels"));
    }
}
