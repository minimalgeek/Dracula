using UnityEngine;
using System.Collections;

public class Spitter : MonoBehaviour {

    public GameObject bullet;
    public float bulletSpeed = 200;
    public float cooldown = 3;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 1, cooldown);
	}
	
    public void Fire()
    {
       GameObject g= Instantiate(bullet, spawnPoint.position, spawnPoint.rotation)as GameObject;
        g.GetComponent<Rigidbody>().AddForce(g.transform.forward*bulletSpeed);
    }
}
