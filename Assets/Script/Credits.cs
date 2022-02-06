using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    
    public void Restart()
    {
        SceneManager.LoadScene("Level");
    }
    public void ManinMneu()
    {
        SceneManager.LoadScene("Menu");
    }
}
