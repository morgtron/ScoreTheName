using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public static LevelManager instance = null;

    public int myScene;
    public int difficulty;

    private ArrayList scenesWereAlreadyLoaded = new ArrayList();
    int sceneToLoad;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        int myScene = SceneManager.GetActiveScene().buildIndex;
        if (myScene == 0)
        {
            FindObjectOfType<GameManager>().score = 0;
        }
    }

    public void LoadLevel(string name)
    {
        Debug.Log("Level Load Requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel()
    {
        if (difficulty == 1) {
            sceneToLoad = Random.Range(1, 16);
            if (!scenesWereAlreadyLoaded.Contains(sceneToLoad))
            {
                scenesWereAlreadyLoaded.Add(sceneToLoad);
                SceneManager.LoadScene(sceneToLoad);
            }
            if (scenesWereAlreadyLoaded.Count > 16)
            {
                SceneManager.LoadScene(17);
            }
        }

        if(difficulty == 2)
        {
            sceneToLoad = Random.Range(17, 32);
            if (!scenesWereAlreadyLoaded.Contains(sceneToLoad))
            {
                scenesWereAlreadyLoaded.Add(sceneToLoad);
                SceneManager.LoadScene(sceneToLoad);
            }
            if (scenesWereAlreadyLoaded.Count > 16)
            {
                SceneManager.LoadScene(17);
            }
        }

        if(difficulty == 3)
        {
            sceneToLoad = Random.Range(33, 47);
            if (!scenesWereAlreadyLoaded.Contains(sceneToLoad))
            {
                scenesWereAlreadyLoaded.Add(sceneToLoad);
                SceneManager.LoadScene(sceneToLoad);
            }
            if (scenesWereAlreadyLoaded.Count > 15)
            {
                SceneManager.LoadScene(17);
            }
        }
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
