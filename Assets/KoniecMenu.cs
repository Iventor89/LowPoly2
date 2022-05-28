using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KoniecMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject koniecMenuUI;
   

    void Update()
    {
        
        if ((PlayerPrefs.GetInt("npc_1") + PlayerPrefs.GetInt("npc_2") + PlayerPrefs.GetInt("npc_3") + PlayerPrefs.GetInt("npc_4")) == 4)
        {
            Debug.Log("koniec");
            koniecMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;

        }
   
    }    
    public void LoadMenu()

    {
        Input.GetKeyDown(KeyCode.KeypadEnter);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
