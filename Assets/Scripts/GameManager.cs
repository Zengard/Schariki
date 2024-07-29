using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _coin;
    [SerializeField] private int _hp;
    [SerializeField] GameObject _Canvas_GameOver;
    [SerializeField] GameObject _Canvas_Finish;
    [SerializeField] csUI_HP _ui_hp;
    [SerializeField] TextMeshProUGUI _ui_coin;

    [SerializeField] float _vremja;
    int coin;
    public void HP(int uron)
    {
        _hp = _hp + uron;
        if(_hp<=0)
        {
            _Canvas_GameOver.SetActive(true);
        }
        //удали сердечко
        _ui_hp.skrut_hp();
    }

    public void Coin(int coin) 
    {
        _coin += coin;
        _ui_coin.text = _coin.ToString(); //загружаем в виджет
    }

    private void Start()
    {
        StartCoroutine(TimerFinish());
    }

    private IEnumerator TimerFinish()
    {
        yield return new WaitForSeconds(_vremja);
        _Canvas_Finish.SetActive(true);
    }
}
