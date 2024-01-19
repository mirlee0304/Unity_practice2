using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBehavior : MonoBehaviour
{
    public Text moneyTxt;
    public Text nameTxt;

    private Animal currentAnimal;
    private int thisId;
    private int[] hp;

    void Start()
    {
        thisId = GameManager.instance.sites[GameManager.currentSite];
        currentAnimal = GameManager.instance.myAnimals[thisId];
        hp = currentAnimal.HP;
    }


    void Update()
    {
        //UI
        moneyTxt.text = GameManager.money + "$";
        nameTxt.text = currentAnimal.name;

        for (int i = 0;i<3;i++)
        {
            if (i==0)
            {

            }
        }






    }


}
