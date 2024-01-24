using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private float zAxiTall;
    // Start is called before the first frame update
    void Start()
    {
        zAxiTall = transform.localScale.z ;
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
                    textMeshPro.text += "/ length" + zAxiTall.ToString();
                }
            }
        }
    }
}
