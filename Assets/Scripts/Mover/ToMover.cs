using UnityEngine;
using System.Collections;

public enum Axis
{
    x, y, z
}

public class ToMover : MonoBehaviour {

    public float moveTime = 0.5f;
    public Axis axis;
    public float distance;
    
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash(axis.ToString(), distance, "loopType", "pingPong", "time", moveTime));
    }

    void Update () {
	
	}
}
