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

    Color lastColor=Color.white;

	public void HightLight() //tudom hogy elírtam,de akkor elvész a beállítás ha átírom :D
    {
        img.color = highLightColor;
    }

    public void StopHightLight()
    {
        img.color = lastColor;
    }
}
