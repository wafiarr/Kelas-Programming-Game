using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    AudioSource audio;
    public AudioClip hitSound;

    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && gameStarted == false)
        {
            transform.SetParent (null);
            rb.isKinematic = false;

            rb.AddForce(new Vector2(ballForce, ballForce));
            gameStarted = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.PlayOneShot(hitSound);
    }
}
