using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CoinPlacer : MonoBehaviour
{
    public List<Transform> locations;
    public GameObject Coin;
    public int numOfCoins = 10;
    void Start()
    {
        int count = locations.Count;
        for (int i = 0; i < numOfCoins; i++)
        {
            int loc = Random.Range(0, count );
            Instantiate(Coin, locations[loc]);
            locations.RemoveAt(loc);
            count--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
