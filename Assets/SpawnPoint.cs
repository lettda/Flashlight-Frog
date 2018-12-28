using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public Bubble[] bubbles; //create an array to hold all the bubbles
    public int count;  //holds number of bubbles to spawn
    public float timeBetweenSpawns; //time between each bubble spawn

    public Transform[] spawnPoints; //araay of avaialble spawn points
    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnBubbles());
	}

    IEnumerator SpawnBubbles () {
        for (int i = 0; i < count; i++) // so long as there are bubbles remaining to spawn
        {
            Bubble randomBubble = bubbles[Random.Range(0, bubbles.Length)];
            Transform randomSpawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomBubble, randomSpawn.position, randomSpawn.rotation);

            yield return new WaitForSeconds(timeBetweenSpawns);

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
