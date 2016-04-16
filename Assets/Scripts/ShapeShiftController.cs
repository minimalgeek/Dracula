using UnityEngine;
using System.Collections;

public class ShapeShiftController : MonoBehaviour {

    public GameObject shapePanel;
    public enum Shapes {Shape1, Shape2, Shape3, Shape4, Shape5, Shape6};
    Shapes lastShape;
    Shapes wantedShape=Shapes.Shape1;

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

    public void SetWantedShape(int n)
    {
        lastShape = wantedShape;
        wantedShape = (Shapes)n;

        foreach (Recolor rc in shapePanel.GetComponentsInChildren<Recolor>())
        {
            rc.StopHightLight();
        }     
    }

    public void KeepShape()
    {
        wantedShape = lastShape;
    }

    void ShapeShift()
    {
        gameObject.layer=LayerMask.NameToLayer(wantedShape.ToString());
    }
}
