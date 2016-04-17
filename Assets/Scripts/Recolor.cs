using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Recolor : MonoBehaviour {
    Image img;
    public Color highLightColor;

  void Start()
    {
     img=GetComponent<Image>();
    }

	public void HighLight() 
    {
        img.color = highLightColor;
    }

    public void StopHightLight()
    {
        img.color = Color.white;
    }
}
