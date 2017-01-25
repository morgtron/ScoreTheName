using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance = null;

    public int myScene;

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
        sceneToLoad = Random.Range(1, 12);
        if (!scenesWereAlreadyLoaded.Contains(sceneToLoad))
        {
            scenesWereAlreadyLoaded.Add(sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
        if (scenesWereAlreadyLoaded.Count > 12)
        {
            SceneManager.LoadScene(13);
        }
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }
}
