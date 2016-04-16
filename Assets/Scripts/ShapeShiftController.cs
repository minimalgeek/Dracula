using UnityEngine;
using System.Collections;

public class ShapeShiftController : MonoBehaviour {

    public GameObject shapePanel;
    public enum Shapes {Shape1, Shape2, Shape3, Shape4, Shape5, Shape6};

    Shapes wantedShape;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
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
        wantedShape = (Shapes)n;
    }

    void ShapeShift()
    {
        gameObject.layer=LayerMask.NameToLayer(wantedShape.ToString());
    }
}
