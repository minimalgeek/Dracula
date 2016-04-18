using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int health=3;


	public void DamageTaken(int dmg)
    {
        health -= dmg;
        if (health<=0)
        {
            GetComponentInChildren<Animator>().SetTrigger("Die");
            GameController.instance.StartGameOver();
            GetComponent<MovementController>().Disable();
            GetComponent<ShapeShiftController>().enabled = false;
            GetComponent<Collider>().enabled = false;
            enabled = false;
        }
    }



}
