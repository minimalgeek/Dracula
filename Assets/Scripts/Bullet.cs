using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

   public int dmg = 1;

   void OnTriggerEnter(Collider c)
    {
        c.GetComponent<Health>().DamageTaken(dmg);
    }
}
