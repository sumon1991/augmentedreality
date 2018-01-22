using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject movement;

    // Use this for initialization
    /*void Start () {
		
	}*/

    // Update is called once per frame
    /* void Update () {

         


         }*/
    public void PauseMenubutton()
    {


        if (GameIsPaused)
        {
            resume();
        }
        else
        {
            pause();
        }
    }

    void pause()
    {
        pauseMenuUI.SetActive(true);
        movement.SetActive(false);
        
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void resume()
    {
        pauseMenuUI.SetActive(false);
        movement.SetActive(true);
       
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void menu(string newGameLevel)
    {

        SceneManager.LoadScene(newGameLevel);

    }

    public void exitgame()
    {
        Application.Quit();
    }
    

	}

