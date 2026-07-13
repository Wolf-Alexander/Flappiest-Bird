using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool over = false;
    public GameManangerScript game;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody.gravityScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 13 && game.hasStarted == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && over == false)
            {
                myRigidbody.linearVelocity = Vector2.up * flapStrength;
            }
        }

        if (transform.position.y < -14 && game.hasStarted == true)
        {
            logic.gameOver();
            over = true;
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        over = true;
    }
}
