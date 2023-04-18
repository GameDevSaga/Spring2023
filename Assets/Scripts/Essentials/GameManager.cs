using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // needed for being able to manage scenes

public class GameManager : MonoBehaviour
{
    public int score = 0; // keeps track of your score

    public static GameManager gameManager;


    void Start()
    {
        if (gameManager == null)
        {
            DontDestroyOnLoad(gameObject); // keeps the game object and its parameters along for the ride between game scenes
            gameManager = this;
        }
        else if(gameManager != this)
        {
            Destroy(gameObject);
        }


    }

    void Update()
    {
        
    }

    /*public void ChangeLevel()
    {
        StartCoroutine(LoadLevel(2));
        //SceneManager.LoadScene("MainGame"); //starts up the main game scene, can also be called by number in build
    }

    public void MenuLevel()
    {
        StartCoroutine(LoadLevel(0));
        //SceneManager.LoadScene("MenuLevel"); // returns to the menu scene
    }

    public void SettingsLevel()
    {
        StartCoroutine(LoadLevel(1));
        //SceneManager.LoadScene("SettingsLevel"); //opens game settings
    }

    public void QuitGame()
    {
        Application.Quit(); //shuts down the game
    }

    public IEnumerator LoadLevel(int levelToLoad)
    {
        fadeScreen.SetTrigger("FadeOut");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelToLoad);
    }*/
}
