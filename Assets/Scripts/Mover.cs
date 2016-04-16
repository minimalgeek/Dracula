using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
    
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("y", -60f, "loopType", "pingPong", "time", 0.3f));
    }

    void Update () {
	
	}
}
