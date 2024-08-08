using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class csScena : MonoBehaviour
{
    [SerializeField] string name_lvl;
    [SerializeField] int nomer_cartu;
    [SerializeField] int nomer_missii;
    [SerializeField] GameObject _image_zamok;
    bool actyvnost_knopki;
    public void start_lvl()
    {
        if (actyvnost_knopki == true)
        {
            SceneManager.LoadScene(name_lvl);
        }
    }

    private void Start()
    {
        
        if (Progress.GameInstance.date.progress_lvl[nomer_cartu - 1] >= nomer_missii)
        {
            actyvnost_knopki = true;
            _image_zamok.SetActive(false);
        }
        else
        {
            actyvnost_knopki = false;
        }

    }
}
