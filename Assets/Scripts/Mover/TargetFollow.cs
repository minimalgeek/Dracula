using UnityEngine;
using System.Collections;

public class TargetFollow : MonoBehaviour {

	public Transform targetToFollow;
	public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 offset;
    
    void Start()
    {
        offset = transform.position - targetToFollow.position;
    }

    void Update() {
		Vector3 destination = targetToFollow.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}
