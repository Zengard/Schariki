using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class csVuvodMonet : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _text_coin;

    private void Start()
    {
        _text_coin.text = Progress.GameInstance.date.Coin.ToString();
    }
}
