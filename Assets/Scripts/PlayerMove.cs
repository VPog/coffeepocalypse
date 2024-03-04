using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D body;
    float horizontal;
    float vertical;
    float diagonalModifier = 0.7f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        //transform.Translate(movement);

        if (horizontal != 0 && vertical != 0)
        {
            horizontal *= diagonalModifier;
            vertical *= diagonalModifier;
        } 

        body.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
    }
}

