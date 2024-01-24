using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private float yAxiTall;
    // Start is called before the first frame update
    void Start()
    {
        yAxiTall =transform.localScale.y;
        GetShapeColor();
        GetShapeName();

    }

    // Update is called once per frame
    void Update()
    {
        DisplayInformation();
    }
    public override void DisplayInformation()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the ray hits the cube
                if (hit.collider.gameObject == gameObject)
                {
                    base.DisplayInformation();
                    textMeshPro.text += "/ height" + yAxiTall.ToString();
                }
            }
        }
    }
}
