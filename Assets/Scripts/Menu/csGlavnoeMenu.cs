using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csGlavnoeMenu : MonoBehaviour
{
    [SerializeField] GameObject _canvas_parent;
    [SerializeField] GameObject _LVL;
    private void skrut_menu()
    {
        _canvas_parent.SetActive(false);

    }

    public void LVL()
    {
        _LVL.SetActive(true);
        skrut_menu();
    }
}
