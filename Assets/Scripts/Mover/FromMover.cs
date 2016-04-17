using UnityEngine;
using System.Collections;

public class FromMover : MonoBehaviour {

    public Axis axis;
    public float distance = -60f;
    public float moveTime = 0.5f;

    void Start()
    {
        iTween.MoveFrom(gameObject, iTween.Hash(axis, distance, "time", moveTime, "easetype", "easeInQuart"));
    }

}
