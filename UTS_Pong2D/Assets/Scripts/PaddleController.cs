using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float Speed;
    public float BatasKanan;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (x < 0)
        {
            MoveLeft();
        } 
        if (x > 0)
        {
            MoveRight();
        }
        if(x == 0)
        {
            Stop();
        }
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp (pos.x, -BatasKanan, BatasKanan);
        transform.position = pos;
    }
    void MoveLeft()
    {
        Rigidbody.velocity = new Vector2(-Speed, 0);
    }
    void MoveRight()
    {
        Rigidbody.velocity = new Vector2(Speed, 0);
    }
    void Stop()
    {
        Rigidbody.velocity = Vector2.zero;
    }
}
