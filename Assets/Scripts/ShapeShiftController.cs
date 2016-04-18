using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Shapes {
    Dracula, Skeleton, Bat, Gargoyle
};

public class ShapeShiftController : MonoBehaviour {

    public GameObject shapePanel;
    
    Shapes wantedShape=Shapes.Dracula;
    public Shapes currentShape = Shapes.Dracula;

    public int shapeShiftCost=1;
    public int maxMana=12;
    public int currentMana;
    public Image[] icons;
    public Color highLightColor;
    public GameObject[] characters;
    public GameObject effect;


	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            shapePanel.SetActive(true);
            Time.timeScale = 0.15f;
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            shapePanel.SetActive(false);
            Time.timeScale = 1;
            ShapeShift();
        }
    }

    public void Disable()
    {
        enabled = false;
    }

    public void SelectShape(int n)
    {
        currentShape = wantedShape;

        wantedShape = (Shapes)n;

        icons[n].color = highLightColor;
    }

    public void UnSelectShape(int n)
    {
        icons[n].color = Color.white;
        wantedShape = currentShape;
    }

    void ShapeShift()
    {
        if (wantedShape != currentShape)
        {
            if (currentMana >= shapeShiftCost)
            {
               
                currentMana -= shapeShiftCost;
                gameObject.layer = LayerMask.NameToLayer(wantedShape.ToString());
                characters[(int)wantedShape].SetActive(true);
                characters[(int)currentShape].SetActive(false);
                if (effect!=null)
                {
                    Instantiate(effect, transform.position, transform.rotation);
                }
                currentShape = wantedShape;
            }
        }
    }
    public void AddMana(int mana)
    {
        currentMana += mana;
        if (currentMana>maxMana)
        {
            currentMana = maxMana;
        }
    }
}
