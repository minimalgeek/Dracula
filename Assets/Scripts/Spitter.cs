using UnityEngine;
using System.Collections;

public class Spitter : MonoBehaviour {

    public GameObject bullet;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", Random.Range(0.3f, 1f), Random.Range(1f, 2.5f));
	}
	
    public void Fire()
    {
       GameObject g= Instantiate(bullet, spawnPoint.position, spawnPoint.rotation)as GameObject;
    }
}
