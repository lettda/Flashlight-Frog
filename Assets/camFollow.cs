using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour {

    public Transform playerTransform;
    public float speed;

    public float minY;
    public float minX;
    public float maxY;
    public float maxX;

	// Use this for initialization
	void Start () {
        transform.position = playerTransform.position; //set the position of the camera = to the current position of the player
	}
	
	// Update is called once per frame
	void Update () {
        if (playerTransform != null) //if player gameObject doesn't exist (i.e. dead)
        {

            float clampedX = Mathf.Clamp(playerTransform.position.x, minX, maxX); //set max boundaries for the camera (whose position is = to the players)
            float clampedY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

            transform.position = Vector2.Lerp(transform.position, new Vector2(clampedX,clampedY), speed); //set the position of the camera = to the new position of the player gameObject
        }

	}
}
