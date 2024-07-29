using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class csUI_HP : MonoBehaviour
{
    [SerializeField] Image[] hp;
    int i = 0;
    public void skrut_hp()
    {
        if (hp[i])
        {
            hp[i].enabled = false;
            i++;
        }
    }
}
