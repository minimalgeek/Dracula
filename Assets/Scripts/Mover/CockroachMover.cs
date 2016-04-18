using UnityEngine;
using System.Collections;

public class CockroachMover : MonoBehaviour {

    public float Speed = 40f;
    public float Range = 60f;
    
    private Vector3 wayPoint;
    private float triggerDistance = 3f;
    private float moveTime = 5f;
    private float yInitPosition;
    
    void Start()
    {
        yInitPosition = transform.position.y;
        Wander();
        Destroy(this.gameObject, 10f);
    }

    void Update()
    {
        if ((transform.position - wayPoint).magnitude < triggerDistance)
        {
            Wander();
        }

        LimitPosition();
    }

    void Wander()
    {
        wayPoint = new Vector3(
            Random.Range(transform.position.x - Range, transform.position.x + Range),
            yInitPosition, 
            Random.Range(transform.position.z - Range, transform.position.z + Range));
        iTween.MoveTo(this.gameObject, wayPoint, moveTime);
        transform.LookAt(wayPoint);
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            ShapeShiftController ssc = coll.GetComponent<ShapeShiftController>();
            if (ssc&& ssc.currentShape== Shapes.Dracula)
            {
                coll.GetComponent<Health>().anim.SetTrigger("Take");
                ssc.AddMana(4);
            }
        }
    }

    private void LimitPosition()
    {
        Vector3 newPosition = transform.position;
        if (newPosition.z < 0)
        {
            newPosition.z = 0;
        }

        if (newPosition.x < 0)
        {
            newPosition.x = 0;
        }

        if (newPosition.y < yInitPosition)
        {
            newPosition.y = yInitPosition;
        }

        transform.position = newPosition;
    }
}
