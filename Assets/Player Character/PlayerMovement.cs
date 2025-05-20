using UnityEngine;
using System.Collections;
//using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();

    }
    //void Update()
    //{//checks and applies the input into every frame
    // update is called before rendering a frame, which is why, most of our code will go here
    //}
    void FixedUpdate()
    {//is called before any physics calculations, which y our physics code will go here

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}