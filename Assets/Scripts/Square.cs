using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Square : Shape
{
    void Awake()
    {
        ShapeName = "square";
        Color = new Color32(33, 109, 25, 1);
    }

    //POLYMORPHISM
    public override void DisplayText()
    {
        message.text = "Child " + ShapeName;
        message.gameObject.SetActive(true);
    }

}
