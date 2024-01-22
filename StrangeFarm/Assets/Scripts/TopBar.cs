using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopBar : MonoBehaviour
{
    public Text moneyTxt;
    public Button settingBtn;
    public Button sleepBtn;

    private Animal currentAnimal;
    private int thisId;

    void Start()
    {
        thisId = GameManager.instance.sites[GameManager.currentSite];
        currentAnimal = GameManager.instance.myAnimals[thisId];
    }

    void Update()
    {
        moneyTxt.text = GameManager.money + "$";

    }

    void SettingOnClick()
    {

    }

    void SleepOnclick()
    {
        currentAnimal.age += 1;
    }
}
