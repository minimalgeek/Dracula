using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

   // public List<Collectable> tasksList; 
    public static GameController instance;
    public GameObject gameOverPanel;

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

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0.1f;
    }
}
