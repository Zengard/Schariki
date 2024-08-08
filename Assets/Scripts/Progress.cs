using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//[System.Serializable] - нужен, чтобы этот класс отображался справа в инспекторе, как публичная переменная
//класс для сохранения переменных на сервере яндекса
[System.Serializable]
public class Date
{
    public int Coin;
    public int usilenie1_minigun;
    public int usilenie2_arta;
    public int usilenie3_zamarozka;
    public int usilenie4_schit;
    public int aptetschka;
    public int [] progress_lvl;
    public bool progress_lvl2;
    public bool progress_lvl3;
}
public class Progress : MonoBehaviour
{
    [SerializeField] GameObject _yandex;
    [SerializeField] Yandex _csYandex;
    private bool _save_yandex;
    public Date date;
    [SerializeField] TextMeshProUGUI _text_save_load;

    //делаем так, чтобы обьект не уничтожался при смене уровней
    //используем его для сохранения прогресса

    //чтобы не возникли ситуации, когда при перезапуске уровня
    //появляется ещё один неудаляемый обьект
    //Мы скажем неудалять самый первый созданный
    //запишем его в особую переменную
    //а все остальные будем удалять, если эта переменная уже записана
    //такое называется синглтон
    public static Progress GameInstance;
    //Awake - эвент, который вызывается при запуске, но раньше, чем эвент Старт
    private void Awake()
    {
        if (GameInstance == null)
        {
            GameInstance = this;
            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        //если это билд для яндекса, то сохраняем всё на сервер
        //если нет, то через плеер преф на устройстве
        if (_yandex.activeSelf)
        {
            _save_yandex = true;
            _csYandex.Load();
        }
        else
        {
            
            date.Coin = PlayerPrefs.GetInt("Coin"); //загрузка денег с пк
            date.usilenie1_minigun = PlayerPrefs.GetInt("usilenie1_minigun");
            date.usilenie2_arta =  PlayerPrefs.GetInt("usilenie2_arta");
            date.usilenie3_zamarozka = PlayerPrefs.GetInt("usilenie3_zamarozka");
            date.usilenie4_schit = PlayerPrefs.GetInt("usilenie4_schit");
            _save_yandex = false;
            
        }


    }

      public void SaveCoin(int zarabotok)
    {

        date.Coin = zarabotok + date.Coin;
        if (_save_yandex)
        {
            //данные в яндекс передаются только как строчка
            //преобразуем класс с данными в строку
            string dateJS = JsonUtility.ToJson(date);
            //и вызываем код в джава скрипт
            _csYandex.Save(dateJS);
        }
        else
        {
            PlayerPrefs.SetInt("Coin", date.Coin); //сохранение денег на пк
            PlayerPrefs.SetInt("usilenie1_minigun", date.usilenie1_minigun);
            PlayerPrefs.SetInt("usilenie2_arta", date.usilenie2_arta);
            PlayerPrefs.SetInt("usilenie3_zamarozka", date.usilenie3_zamarozka);
            PlayerPrefs.SetInt("usilenie4_schit", date.usilenie4_schit);
 
}
    }

    //для загрузки на старте вызываем функцию в яндексе
    //она вызывает функцию в js
    //он вызывает функцию в яндекс c#
    //и уже он потом вызывает этот метод
    public void LoadCoin(string value)
    {
        
        date = JsonUtility.FromJson<Date>(value);
      /*  if (_text_save_load)
        {
            _text_save_load.text = date.Coin + "\n" +
        date.usilenie1_minigun + "\n" +
        date.usilenie2_arta + "\n" +
        date.usilenie3_zamarozka + "\n" +
        date.usilenie4_schit;
            //заполнение всех полей
        }*/


    }

    //использование усиления
    public void Usilenie(int nomer)
    {
        if(nomer == 1)
        {
            date.usilenie1_minigun--;
        }
        else if(nomer == 2)
        {
            date.usilenie2_arta--;
        }
        else if (nomer == 3)
        {
            date.usilenie3_zamarozka--;
        }
        else if (nomer == 4)
        {
            date.usilenie4_schit--;
        }

        SaveCoin(0);
    }
}
