using UnityEngine;
using System.Collections;

public class BugGenerator : MonoBehaviour {

    public GameObject bugToInitialize;
    public float generateTime = 2f;
	
	void Start () {
        InvokeRepeating("Generate", 0f, generateTime);
	}
	
	private void Generate()
    {
        Instantiate(bugToInitialize, transform.position, Quaternion.identity);
    }
}
