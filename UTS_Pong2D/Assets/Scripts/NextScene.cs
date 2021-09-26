using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
  
    
    void start()
    {
        
    }
    
    public void NextLevel(string Level2)
    {
        SceneManager.LoadScene(Level2);
        Time.timeScale = 1f;
    }
}
