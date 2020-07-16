using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject gameOverScreen;
    private AudioSource source;
   public void Win()
    {
        winScreen.SetActive(true);
    }  
    public void EndScreen()
    {
        gameOverScreen.SetActive(true);
        Invoke("Restart", 1.2f);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
