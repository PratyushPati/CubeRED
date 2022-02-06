using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    
    public static int score=0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score=score +1;
            scoreText.text = score.ToString("0");
            
        }
        PlayerPrefs.SetInt("SCORE", score);
       
    }
    void Update()
    {
        //scoreText.text = (player.position.z+67).ToString("0");
        //scoreText.text = score.ToString("0");
        
    }
    void Start()
    {
        score=0;
    }

}
