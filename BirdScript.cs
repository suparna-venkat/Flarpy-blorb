using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        // Optional: detect falling
        if (transform.position.y < -10 && birdIsAlive)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            // Optional: check specific objects
            if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe"))
            {
                birdIsAlive = false;
                logic.gameOver();
            }
        }
    }
}