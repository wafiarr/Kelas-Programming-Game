using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
