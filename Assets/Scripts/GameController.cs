using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

   // public List<Collectable> tasksList; 
    public static GameController instance;
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    void Awake()
    {
        instance = this;
    }

    //void Start()
    //{
    //    tasksList[0].Activate();
    //}

    //internal void OnFinishTask()
    //{
    //    if (tasksList.Count==0)
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //        return;
    //    }
    //    tasksList.RemoveAt(0);
    //    tasksList[0].Activate();
    //}

    public void StartGameOver()
    {
        Invoke("GameOver", 5);
        Time.timeScale = 0.5f;
    }

   void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
