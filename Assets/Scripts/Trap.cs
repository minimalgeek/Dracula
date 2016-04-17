using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {


    public int damage=1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            c.GetComponent<Health>().DamageTaken(damage);
        }
    }
}
