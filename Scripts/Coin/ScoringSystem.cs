using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoringSystem : MonoBehaviour
{
    public GameObject CoinCounter;
    public GameObject Timer;
    public GameObject UI;
    public static int scorenya;
    public static float seconds = 0.0f;
   
    void Update()
    {
        CoinCounter.GetComponent<TextMeshProUGUI>().text = "Coin Terkumpul : " + scorenya + " dari 6";     

        TimeSpan timer = TimeSpan.FromSeconds(seconds);
        Timer.GetComponent<TextMeshProUGUI>().text = timer.ToString(@"mm\:ss\:ff");

        if(scorenya > 0 && scorenya < 6)
        {
            seconds += Time.deltaTime;
        }

        if(scorenya > 0){
            UI.GetComponent<Animator>().SetTrigger("timerStart");
        }

        if(scorenya > 5){
            UI.GetComponent<Animator>().SetTrigger("timerStop");
        }
        
        
    }
}
