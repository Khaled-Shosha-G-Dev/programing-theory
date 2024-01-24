using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Sphere : Shape
{
    private float xAxiTall;
    // Start is called before the first frame update
    void Start()
    {
        xAxiTall = transform.localScale.x;
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
                    textMeshPro.text += "/ width" + xAxiTall.ToString();
                }
            }
        }
    }
}
