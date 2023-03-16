using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    //float variabke for player's moving speed (left/right)
    public float speed;

    //variable for player's rigidbody 2D component
    Rigidbody2D rb;

    //float variable for horizontal axis value from input manager
    float x;

    //variable for calculated vector, which will be used for velocity changes
    Vector2 move;

    // this function will be executed once a script is enabled
    void Start()
    {
        //reference to Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    // this function will be executed every fixed time step
    void FixedUpdate()
    {
        //set variable x to value, which we can get from input manager horizontal axis
        x = Input.GetAxis("Horizontal");

        //calculate moving vector and y value will stay unchanged
        move = new Vector2(x * speed, rb.velocity.y);

        //change players-'s velocity (move it left/right or stop)
        rb.velocity = move;
    }
}
