using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//mixamo
public class ShapeShiftController : MonoBehaviour {

    public GameObject shapePanel;
    public enum Shapes {Shape1, Shape2, Shape3, Shape4, Shape5, Shape6};
    Shapes wantedShape=Shapes.Shape1;
    Shapes currentShape = Shapes.Shape1;
    public int shapeShiftCost=1;
    public int maxMana=12;
    public Image[] icons;
    public Color highLightColor;
    public GameObject[] shapes;
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
            if (maxMana >= shapeShiftCost)
            {
                gameObject.layer = LayerMask.NameToLayer(wantedShape.ToString());
                shapes[(int)wantedShape].SetActive(true);
                shapes[(int)currentShape].SetActive(false);
                if (effect!=null)
                {
                    Instantiate(effect, transform.position, transform.rotation);
                }
            }
        }
    }
}
