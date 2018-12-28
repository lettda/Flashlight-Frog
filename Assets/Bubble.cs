using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour {

    public float speed;
    public int timeToPop;
    public static int value;
    private Vector2 destinationPosition;

    //public float minY;
    public float maxY;
    public float minX;
    public float maxX;

    [HideInInspector]
    public Transform player;

    public GameObject popped;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform; //get the player gameObject's current position
        float randomX = Random.Range(minX, maxX); //set a random value on the X axis (horizontal)
        destinationPosition = new Vector2(randomX, maxY); //create a position the bubble will move to
        Invoke("PopBubble", timeToPop); //after a specified time destory the bubble if it hasn't been hit by the player
        	
	}

    void PopBubble () { //pop bubble after specified time has passed
        Instantiate(popped, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision) //if the bubble collides with the player add it's value to player's score
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<player>().AddToScore(value);
            PopBubble();
        }
    }

    // Update is called once per frame
    void Update () {
            transform.position = Vector2.MoveTowards(transform.position, destinationPosition, speed * Time.deltaTime); //bubble will float up from it's spawn position toward the destination position
        
    }
}
