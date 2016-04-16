using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

    bool active = false;
    [HideInInspector]
   public GameController gc;

    void Start()
    {
        gc = GameController.instance;
        if (!gc)
        {
            Debug.Log("Gamecontroller hiányzik!");
        }
    }
    void OnTriggerEnter(Collider coll)
    {
        if (active)
        {

            ///TODO
            Finish();
            Destroy(gameObject);
        }
      
    }

    public void Activate()
    {
        active = true;
    }

    void Finish()
    {
        active=false;
        //gc.OnFinishTask();
    }

}
