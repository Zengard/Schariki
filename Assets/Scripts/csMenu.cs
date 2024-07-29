using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class csMenu : MonoBehaviour
{
    [SerializeField] GameObject _self_UI;
    // Start is called before the first frame update
    void Start()
    {
        //пауза
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        //сн€тие паузы
        Time.timeScale = 1f;
        //получение ссылки на открытую сцену и еЄ перезагрузка
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Play()
    {
        //сн€тие паузы
        Time.timeScale = 1f;
        _self_UI.SetActive(false);
    }

    public void Glavnie_menu()
    {
        //сн€тие паузы
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
