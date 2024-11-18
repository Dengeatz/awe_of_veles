using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WinterEvening._Scripts.Utils
{
    public class SceneLoader
    {
        public IEnumerator LoadScene(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
        }
    }
}