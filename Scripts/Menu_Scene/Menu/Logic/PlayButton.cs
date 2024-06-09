using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Canvas loading_screen;
    public void toPlay()
    {
        loading_screen.gameObject.SetActive(true);
        StartCoroutine(Loading_Scene());
    }

    IEnumerator Loading_Scene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Template");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
