using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csUI_usilenie : MonoBehaviour
{
    [SerializeField] GameObject _usilenie1;
    [SerializeField] GameObject _usilenie2;
    [SerializeField] GameObject _usilenie3;
    [SerializeField] GameObject _usilenie4;

    bool actyve = false;
    [SerializeField] GameManager _gameManager;

    [SerializeField] GameObject _minigan;
    [SerializeField] GameObject _artobstrel;

    public void Pokaz_usileniy()
    {
        if (actyve)
        {
            actyve = false;
        }
        else
        {
            actyve = true;
        }
        _usilenie1.SetActive(actyve);
        _usilenie2.SetActive(actyve);
        _usilenie3.SetActive(actyve);
        _usilenie4.SetActive(actyve);
    }

    public void Minigan()
    {
        _minigan.SetActive(true);
    }
    public void Artobstrel()
    {
        _artobstrel.SetActive(true);
    }
}

