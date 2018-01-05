using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        var gameScene = SceneManager.GetSceneByName("02_Game");
        if (gameScene.buildIndex != currentIndex && Input.GetKeyDown(KeyCode.Space))
        {
            LoadGameScene();
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }

	}

    public void LoadGameScene()
    {
        // Load Scene
        SceneManager.LoadScene("02_Game");
    }

    void EndGame()
    {
        SceneManager.LoadScene("03_GameOver");
    }
}
