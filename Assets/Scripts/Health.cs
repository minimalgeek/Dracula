using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int health=10;
    int maxHealth;
    public Animator anim;
    public Bar hpBar;

    void Start()
    {
      anim=  GetComponentInChildren<Animator>();
        maxHealth = health;
    }

	public void DamageTaken(int dmg)
    {
        if (isActiveAndEnabled)
        {
            health -= dmg;
            if (health <= 0)
            {
                hpBar.Calculate(maxHealth, health);
                anim.SetTrigger("Die");
                GameController.instance.StartGameOver();
                GetComponent<PlayerController>().Disable();
                GetComponent<ShapeShiftController>().Disable();
                //GetComponent<Collider>().enabled = false;
                enabled = false;
            }
        }
    }



}
