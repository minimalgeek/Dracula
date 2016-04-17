using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float moveTime = 0.5f;
    
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("y", -60f, "loopType", "pingPong", "time", moveTime));
    }

    void Update () {
	
	}
}
