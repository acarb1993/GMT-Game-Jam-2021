using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Image progressBar;

    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation NextScene = SceneManager.LoadSceneAsync(2);

        while (NextScene.progress < 1)
        {
            progressBar.fillAmount = NextScene.progress;
            yield return new WaitForEndOfFrame();
        }
    }
}
