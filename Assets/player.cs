using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float speed;
    public int health;
    private int score;

    private Rigidbody2D rb;
    private Vector2 moveAmount;

   

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>(); //target the rigid body component on the game object
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); //Create new vector 2 object to hold movement direction = to key direction pressed
        moveAmount = moveInput.normalized * speed; //move in the moveInput direction at a given speed
         
	}

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime); //move the rigid body component from it's current position in the input direction at the divices framerate
    }
}
