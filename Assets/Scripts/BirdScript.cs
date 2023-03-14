using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public LogicManagerScript logic;
    public float upVelocity = 22;
    public bool birdIsAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        

            if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            {
                myRigidbody.velocity = UnityEngine.Vector2.up * upVelocity;
            }

            if (transform.position.y > 17 || transform.position.y < -17)
            {
                doGameOver();
            }

        
        

    }

    private void OnCollisionEnter2D(Collision2D colision) {
        doGameOver();
    }


    private void doGameOver() {
        birdIsAlive = false;
        logic.gameOver();
    }


}
