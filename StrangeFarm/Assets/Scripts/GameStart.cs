using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public Button startBtn;
    public Button restartBtn;
    public Button exitBtn;

    private Text startTxt;
    private Text restartTxt;
    private Text exitTxt;


    void Start()
    {
        startTxt = startBtn.GetComponentInChildren<Text>();
        restartTxt = restartBtn.GetComponentInChildren<Text>();
        exitTxt = exitBtn.GetComponentInChildren<Text>();
    }

    void Update()
    {
        startTxt.text = "START";
        restartTxt.text = "RESTART";
        exitTxt.text = "EXIT";
    }

    public void StartOnClick()
    {
        Debug.Log("GameStarted");
        SceneManager.LoadScene("ShopScene");
    }
    public void RestartOnClick()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void ExitOnClick()
    {
        Application.Quit();
    }
}
