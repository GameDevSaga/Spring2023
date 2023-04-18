using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public PauseScript pause;
    public Animator fadeScreen;
    public float transitionTime;


    // Start is called before the first frame update
    void Start()
    {
        pause = GetComponent<PauseScript>();
        fadeScreen = GameObject.Find("FadeScreen").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeLevel()
    {
        pause.paused = false;
        StartCoroutine(LoadLevel(2));
        //SceneManager.LoadScene("MainGame"); //starts up the main game scene, can also be called by number in build
    }

    public void MenuLevel()
    {
        pause.paused = false;
        StartCoroutine(LoadLevel(0));
        //SceneManager.LoadScene("MenuLevel"); // returns to the menu scene
    }

    public void SettingsLevel()
    {
        pause.paused = false;
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
    }

}
