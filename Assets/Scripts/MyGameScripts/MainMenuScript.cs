using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public Animator fadeScreen;
    public float transitionTime;


    // Start is called before the first frame update
    void Start()
    {
        fadeScreen = GameObject.Find("FadeScreen").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void FirstLevel()
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
        Time.timeScale = 1f;
        fadeScreen.SetTrigger("FadeOut");
        
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelToLoad);
    }

}

