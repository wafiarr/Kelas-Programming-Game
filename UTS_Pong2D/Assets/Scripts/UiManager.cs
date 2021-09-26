using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    AudioSource audio;
    public AudioClip hitSound;

    int score = 0;
    public Text scoreText;
    public GameObject CanvasMenang;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score : " + score;
        if(score >= 14)
        {
            Debug.Log("You Win!");
            CanvasMenang.SetActive(true);
        }
    }
}
