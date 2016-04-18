using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {

    //public float value = 0;
   // public float maxValue = 1;
    public Transform foreground;

    public void Calculate(float max,float current)
    {
        foreground.localScale = new Vector3(1*(current/max), 1);
    }
}
