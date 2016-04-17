using UnityEngine;
using System.Collections;

public class StickMover : MonoBehaviour {

    public float speedInTime;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, speedInTime);
        iTween.MoveBy(this.gameObject, iTween.Hash("y", 800, "easetype", "easeOutQuad", "time", speedInTime));
    }
	
	void Update () {
        
    }
}
