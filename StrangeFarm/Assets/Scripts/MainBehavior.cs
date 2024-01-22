using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainBehavior : MonoBehaviour
{
    public Text nameTxt;
    public Text siteTxt;

    private Animal currentAnimal;
    private int thisId;
    private int[] hp;

    private GameObject[] bars;
    
    void Start()
    {
        thisId = GameManager.instance.sites[GameManager.currentSite];
        currentAnimal = GameManager.instance.myAnimals[thisId];
        hp = currentAnimal.HP;

        bars = GameObject.FindGameObjectsWithTag("HP");

    }

    void Update()
    {
        //UI
        nameTxt.text = currentAnimal.name;
        siteTxt.text = "#"+GameManager.currentSite.ToString();

        for (int i = 0;i<3;i++)
        {
            bars[i].GetComponentsInChildren<Image>()[hp[i]].enabled = true;
        }
    }

    void FoodOnClick()
    {
        if(hp[0] < 3)
        {
            GameManager.money -= 10 * currentAnimal.age;
            hp[0] += 1;
        }
    }

    void WaterOnClick()
    {
        if (hp[0] < 3)
        {
            GameManager.money -= 10 * currentAnimal.age;
            hp[1] += 1;
        }
    }

    void PlayOnClick()
    {
        if (hp[0] < 3)
        {
            GameManager.money -= 10 * currentAnimal.age;
            hp[2] += 1;
        }
    }

    void LeftOnClick()
    {
        //ㅇㅕㄱㅣ ㄷㅏㅅㅣ ㄱㅣㅎㅚㄱ
        GameManager.currentSite -= 1;
        if (GameManager.currentSite == 0)
        {
            SceneManager.LoadScene("SiteScene");
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void RightOnClick()
    {
        GameManager.currentSite += 1;
        if (GameManager.currentSite == 0)
        {
            SceneManager.LoadScene("SiteScene");
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    void ShopOnClick()
    {
        SceneManager.LoadScene("ShopScene");
    }

    void SiteOnClick()
    {
        SceneManager.LoadScene("SiteScene");
    }
}
