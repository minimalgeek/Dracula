using UnityEngine;
using System.Collections;

public class FromMover : MonoBehaviour {

    private static bool singletonMarker = true; // temporary hack

    public Axis axis;
    public float distance = -60f;
    public float moveTime = 0.5f;

    void Start()
    {
        if (singletonMarker)
        {
            iTween.MoveFrom(gameObject, iTween.Hash(axis, distance, "time", moveTime, "easetype", "easeInQuart"));
        }
        singletonMarker = false;
    }

}
