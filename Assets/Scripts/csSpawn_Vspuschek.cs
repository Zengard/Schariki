using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csSpawn_Vspuschek : MonoBehaviour
{
    [SerializeField] GameObject _vspuschka_prefab;
    [SerializeField] int _tschislo;
    int i_spawn = 0;

    void Start()
    {
       // Spawn_vspuschki();
    }



    public void Spawn_vspuschki()
    {
        if (i_spawn <= _tschislo)
        {


            for (int i = 0; i < 4; i++)
            {
                GameObject Vspuschka = Instantiate(_vspuschka_prefab);
                Vspuschka.transform.position = new Vector3(
                    Random.Range(-10, 10),
                    Random.Range(-5, 5), 0);
                i_spawn++;
            }
            StartCoroutine(Timer());
        }
        else
        {
            i_spawn=0;
            gameObject.SetActive(false);
        }
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.3f);
        Spawn_vspuschki();
    }
}
