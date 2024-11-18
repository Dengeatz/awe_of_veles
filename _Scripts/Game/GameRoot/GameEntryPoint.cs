using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using WinterEvening._Scripts.Utils;
using Zenject;

namespace WinterEvening._Scripts.Game.GameRoot {
    public class GameEntryPoint
    {
        private static GameEntryPoint _instance;
        private Coroutines _coroutines;
        
        [Inject]
        private SceneLoader _sceneLoader;
        
        private GameEntryPoint()
        {
            _coroutines = new GameObject("[COROUTINES]").AddComponent<Coroutines>();
            Object.DontDestroyOnLoad(_coroutines);
        }

        public void Run()
        {
            var sceneName = SceneManager.GetActiveScene().name;
            if (sceneName.Equals(Scenes.BOOT))
            {
                _coroutines.StartCoroutine(LoadAndStartMenu());
            }
        }

        private IEnumerator LoadAndStartGame()
        {
            yield return _sceneLoader.LoadScene("Boot");
            yield return _sceneLoader.LoadScene("Gameplay");
            
            Debug.Log("Game Started");
        }

        private IEnumerator LoadAndStartMenu()
        {
            yield return _sceneLoader.LoadScene("Boot");
            yield return _sceneLoader.LoadScene("Menu");
            
            Debug.Log("Menu opened");
        }
    }
}