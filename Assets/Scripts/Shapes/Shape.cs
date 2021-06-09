using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    public Text message;
    private string m_shapeName = "shape";
    //ENCAPSULATION
    public string ShapeName
    {
        get { return m_shapeName;  }
        set { 
            if (value.Length > 15)
            {
                Debug.Log("The name's length mustn't exceed 15 characters!");
            }
            else
            {
                m_shapeName = value;
            }
        }
    }
    private Color m_color = new Color32(133, 79, 55, 1);
    //ENCAPSULATION
    public Color Color
    {
        get { return m_color; }
        set { m_color = value;}
    }

    protected void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color;
    }

    public virtual void DisplayText()
    {
        message.text = ShapeName;
        message.gameObject.SetActive(true);
        //ABSTRACTION
        StartCoroutine(HideText());
    }

    protected void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //ABSTRACTION
            DisplayText();
        }
    }

    protected IEnumerator HideText()
    {
        yield return new WaitForSeconds(2);
        message.gameObject.SetActive(false);
    }
}
