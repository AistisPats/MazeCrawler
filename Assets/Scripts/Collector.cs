using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private int CoinCount = 0;

    public TextMeshProUGUI Coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Coins.text = CoinCount.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            CoinCount++;
        }
    }
}
