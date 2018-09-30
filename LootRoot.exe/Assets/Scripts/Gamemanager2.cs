using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Gamemanager2 : MonoBehaviour {

    public static Gamemanager2 instance = null;

    int score = 0;

    public int levels;
    int currentLevel = 1;

    private void Awake()
    {
        levels = 1;
        DontDestroyOnLoad(gameObject);
        
    }

    private void Update()
    {

    }

    public void NextLevel()
    {
        currentLevel += 1;
        SceneManager.LoadScene("level"+currentLevel);
    }

    public void Looted()
    {
        score += 1;
    }

}
