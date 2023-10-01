using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hcontr : MonoBehaviour 
{
    public GameObject MyStats;
    public GameObject VragStats;

    public GameObject TextWin;
    public GameObject TextLose;

    public Slider SlidMyHealth;
    public Slider SlidVragHealth;

    float myCurHealth;
    float vragCurHealth;

    int myAttack;
    int minMyAttack = 10;
    int maxMyAttack = 20;

    int VragAttack;
    int minVragAttack = 5;
    int maxVragAttack = 15;

    void Update()
    {
        myCurHealth = SlidMyHealth.value;
        vragCurHealth = SlidVragHealth.value;

        if (myCurHealth<=0)
        {
        MyStats.SetActive (false);
        VragStats.SetActive (false);
        TextLose.SetActive (true);
        }

        if (vragCurHealth<=0)
        {
        MyStats.SetActive (false);
        VragStats.SetActive (false);
        TextWin.SetActive (true);
        }
    }

    public void Meattack(){
        myAttack = Random.Range (minMyAttack, maxMyAttack);
        SlidVragHealth.value=SlidVragHealth.value-myAttack;
        VragAttack = Random.Range (minVragAttack, maxVragAttack);
        SlidMyHealth.value=SlidMyHealth.value-VragAttack;
    }
}