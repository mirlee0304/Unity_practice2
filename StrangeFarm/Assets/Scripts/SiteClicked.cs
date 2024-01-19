using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SiteClicked : MonoBehaviour
{
    public int siteNum;

    void Start()
    {
        siteNum = int.Parse(GetComponentInChildren<Text>().text);
    }

    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("Button Clicked: " + siteNum);
        GameManager.currentSite = siteNum;

        SceneManager.LoadScene("MainScene");
        
    }
}
