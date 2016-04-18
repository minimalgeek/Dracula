using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {
    Rigidbody rb;
    public float speed = 50;
	// Use this for initialization
	void Start () {
       rb= GetComponent<Rigidbody>();
        rb.AddForce(transform.right*speed, ForceMode.Impulse);
	}
	
	void OnTriggerEnter(Collider c)
    {
        if (c.tag=="Player")
        {
            c.GetComponent<Health>().DamageTaken(500);
        }
    }
}
