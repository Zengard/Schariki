using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class csStik : MonoBehaviour
{
    [SerializeField] GameObject zentr_stika;
    bool test;
    public void Stik_naschat()
    {/*
        if (GUI.RepeatButton(new Rect(25, 25, 100, 30), "RepeatButton"))
        {
            Debug.Log(12345);
            transform.position = Input.mousePosition;
        }*/
    }

    private void Update()
    {
        if (test)
        {
            transform.position = Input.mousePosition;
        }
    }
   public void OnDrag()
    {
        Debug.Log(12345);
    }

    /*
    private void OnMouseDown()
    {
        Debug.Log(12345);
        test = true;
    }

    private void OnMouseUp()
    {
        test = false;
    }
    */
}
