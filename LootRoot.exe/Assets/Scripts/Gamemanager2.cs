using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Gamemanager2 : MonoBehaviour {

    public static Gamemanager2 instance = null;

    int triesLeft = 3;
    int score = 0;

    public int levels;
    int currentLevel = 1;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            NextLevel();
        }

    }

    public void NextLevel()
    {
        SceneManager.LoadScene("level"+currentLevel);
        currentLevel += 1;
    }

}
