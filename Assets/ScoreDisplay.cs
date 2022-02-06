using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text SCORE;
    // Start is called before the first frame update
    void Start()
    {
        SCORE.text = PlayerPrefs.GetInt("SCORE").ToString("0");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
