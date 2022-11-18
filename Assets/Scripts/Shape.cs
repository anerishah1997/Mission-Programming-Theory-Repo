using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    protected Color shapeColor;
    protected MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void DisplayText()
    {
        Debug.Log("This is SHAPE");
    }

    public virtual void DisplayColor()
    {
        
    }
}
