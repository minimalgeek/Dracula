using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int health=3;
    public Animator anim;

    void Start()
    {
      anim=  GetComponentInChildren<Animator>();
    }

	public void DamageTaken(int dmg)
    {
        if (isActiveAndEnabled)
        {
            health -= dmg;
            if (health <= 0)
            {
                anim.SetTrigger("Die");
                GameController.instance.StartGameOver();
                GetComponent<PlayerController>().Disable();
                GetComponent<ShapeShiftController>().Disable();
                GetComponent<Collider>().enabled = false;
                enabled = false;
            }
        }
    }



}
