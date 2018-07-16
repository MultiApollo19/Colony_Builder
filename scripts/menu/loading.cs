using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loading : MonoBehaviour
{

    public GameObject Loadingprogress;
    public Slider slider;
    public GameObject Buttons;
    public GameObject loadingscreen;
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
        Buttons.SetActive(false);
        loadingscreen.SetActive(true);
        Cursor.visible = false;
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress/.9f);
            slider.value = progress;
            yield return null;
        }
    }
}