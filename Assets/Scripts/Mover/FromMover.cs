using UnityEngine;
using System.Collections;

public class FromMover : MonoBehaviour {

    public float yFrom = 0f;
    public float moveTime = 0.5f;

    void Start()
    {
        iTween.MoveFrom(gameObject, iTween.Hash("y", yFrom, "time", moveTime, "easetype", "easeInQuart"));
    }

    void Update()
    {

    }
}
