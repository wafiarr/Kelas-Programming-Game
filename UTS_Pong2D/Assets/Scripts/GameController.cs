using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Button NextButton;
    
    // Start is called before the first frame update
    void Start()
    {
        print("Game Restarted");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
