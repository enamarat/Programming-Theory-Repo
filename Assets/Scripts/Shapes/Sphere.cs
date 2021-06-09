using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    void Awake()
    {
        ShapeName = "sphere";
        Color = new Color32(233, 179, 105, 1);
    }

    //POLYMORPHISM
     public override void DisplayText()
     {
        message.text = "Child " + ShapeName;
        message.gameObject.SetActive(true);
     }
}
