using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int score;
   

     void Update()
    {
        
        
        scoreText.GetComponent<Text>().text = "Notes Found " + score + "/3";
       
    }
}
