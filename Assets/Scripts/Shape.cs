using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    private Color shapeColor;
    private string name;
    private Renderer shapeRenderer;
    public TextMeshProUGUI textMeshPro;
    public Color ShapeColor {
        get { return shapeColor; }

        set { shapeColor = value; } 
    }
    public string Name { 
        get { return name; } 
        set { name = value; }
    }

    public virtual void DisplayInformation()
    {
 
        textMeshPro.text = "Shape Name : "+Name+"/"+"Color : "+ShapeColor;
    }

    public void GetShapeColor()
    {
        shapeRenderer = GetComponent<Renderer>();
        ShapeColor = shapeRenderer.material.color;
    }
    public void GetShapeName()
    {
        Name=gameObject.name;
    }
   
}
