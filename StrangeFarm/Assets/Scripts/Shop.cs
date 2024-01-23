using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.money>=30)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        GameManager.money -= 30;
        gameObject.SetActive(false);
    }
}
