using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button play;
    public Button quit;






    private void Start()
    {
        play.onClick.AddListener(() => StartGame());
        quit.onClick.AddListener(() => ExitGame());
    }
    public void StartGame() 
    {
        SceneManager.LoadScene("Game");
        Debug.Log("start game");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
