using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cylinder : Shape
{
    void Awake()
    {
        ShapeName = "cylinder";
        Color = new Color32(200, 20, 75, 1);
    }

    //POLYMORPHISM
    public override void DisplayText()
    {
        message.text = "Child " + ShapeName;
        message.gameObject.SetActive(true);
    }
}
