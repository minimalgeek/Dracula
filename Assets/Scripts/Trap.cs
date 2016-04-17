using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

    public int damage=1;
    
	void Start () {
	
	}
	
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
