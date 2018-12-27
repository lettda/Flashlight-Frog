using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour {

    public float speed;
    public float timeToPop;
    public int value;
    private Vector2 destinationPosition;

    public float minY;
    public float maxY;
    public float minX;
    public float maxX;

    [HideInInspector]
    public Transform player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        float randomX = Random.Range(minX, maxX);
        destinationPosition = new Vector2(randomX, maxY);
        	
	}
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, destinationPosition, speed * Time.deltaTime);
        }
    }
}
