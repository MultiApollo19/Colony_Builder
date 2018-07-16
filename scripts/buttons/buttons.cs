using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public GameObject player;
    public static bool Gamepause = false;
    public GameObject pauseui;
    public GameObject menu_hud;
    //public GameObject dialogi;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gamepause)
            {
                
                Resume();
                
                //dialogi.SetActive(true);
            }
            else
            {
                
                Pause();
                
                //dialogi.SetActive(false);
            }
        }
    }
    void Pause()
    {
        player.GetComponent<playerMov>().enabled = false;
        menu_hud.SetActive(false);
        pauseui.SetActive(true);
        Time.timeScale = 0f;
        Gamepause = true;
        Cursor.visible = true;
    }
    public void Resume()
    {
        player.GetComponent<playerMov>().enabled = true;
        pauseui.SetActive(false);
        Time.timeScale = 1f;
        Gamepause = false;
        Cursor.visible = false;
        menu_hud.SetActive(true);
        //dialogi.SetActive(true);
    }
    public void Exit(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Time.timeScale = 1f;
        Cursor.visible = true;
    }
    public void Quit()
    {
        Application.Quit();
    }
    //wczytywanie sceny
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            yield return null;
        }
    }

}
