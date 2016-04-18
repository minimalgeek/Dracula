using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int health=3;

	public void DamageTaken(int dmg)
    {
        if (isActiveAndEnabled)
        {
            health -= dmg;
            if (health <= 0)
            {
                GetComponentInChildren<Animator>().SetTrigger("Die");
                GameController.instance.StartGameOver();
                GetComponent<PlayerController>().Disable();
                GetComponent<ShapeShiftController>().Disable();
                GetComponent<Collider>().enabled = false;
                enabled = false;
            }
        }
    }



}
