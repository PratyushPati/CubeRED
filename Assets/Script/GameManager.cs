using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    
   public void EndGame()
    {
        if(gamehasended== false)
        {
            gamehasended = true;
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene("Credits");
    }
   
}
