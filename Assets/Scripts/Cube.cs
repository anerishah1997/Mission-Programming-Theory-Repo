using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // showing Inheritance.
{
    // Start is called before the first frame update
    void Start()
    {
        shapeColor = Color.red; // setting color of the shape.
        meshRenderer = GetComponent<MeshRenderer>(); // for the color to be applied on the actual gameobject.
    } 

    
    // color and text display on Mouse click.
    private void OnMouseUp()
    {
        // showing abstraction.
        DisplayText();
        DisplayColor();
    }

    // Showing Polymorphism.
    public override void DisplayText()
    {
        Debug.Log("This is Cube");
    }

    // Showing Polymorphism.
    public override void DisplayColor()
    {
        meshRenderer.material.color = shapeColor; // setting the color of the shape.
    }
}
