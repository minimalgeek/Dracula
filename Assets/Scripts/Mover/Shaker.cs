using UnityEngine;
using System.Collections;

public class Shaker : MonoBehaviour {

    public float shakeDistance = 5f;
    public float shakeTime = 0.5f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        iTween.ShakePosition(this.gameObject, new Vector3(shakeDistance, shakeDistance, shakeDistance), shakeTime);
    }
}
