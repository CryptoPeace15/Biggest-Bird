using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float movementSpeed;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && birdIsAlive == true)
        {
            Vector2 currentVelocity = myRigidBody.velocity;
            myRigidBody.velocity = new Vector2((1*movementSpeed), currentVelocity.y);
            Debug.Log("Moving right at: " + myRigidBody.velocity);
        }

        if (Input.GetKeyDown(KeyCode.A) && birdIsAlive == true)
        {
            Vector2 currentVelocity = myRigidBody.velocity;
            myRigidBody.velocity = new Vector2((-1*movementSpeed), currentVelocity.y);
            Debug.Log("Moving left at: " + myRigidBody.velocity);
        }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true) {
            Vector2 currentVelocity = myRigidBody.velocity;
            myRigidBody.velocity = new Vector2(currentVelocity.x, (1*movementSpeed));
            Debug.Log("Moving up at: " + myRigidBody.velocity);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Dead");
        logic.gameOver();
        birdIsAlive = false;
    }
}

