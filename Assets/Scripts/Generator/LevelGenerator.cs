using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

    public List<GameObject> tileList;
    public float xDistance = 800f;
    public float xDistanceIncrement = 800f;

    private GameObject player;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () {
        float playerDistance = player.transform.position.x;
        if (playerDistance + xDistanceIncrement > xDistance)
        {
            int idx = Random.Range(0, tileList.Count);
            GameObject newTile = (GameObject) Instantiate(tileList[idx], new Vector3(xDistance, 0, 0), Quaternion.identity);
            xDistance += xDistanceIncrement;
        }
	}
}
