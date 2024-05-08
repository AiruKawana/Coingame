using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomCoin : MonoBehaviour
{
    [SerializeField] private GameObject prefabCoin;
    [SerializeField] private float XRangeMin = -1.575412f;
    [SerializeField] private float XRangeMax = -1.6f;
    [SerializeField] private float ZRangeMin = 3.198478f;
    [SerializeField] private float ZRangeMax = 3.2f;
    [SerializeField] private float Height = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        for (int r = 1; r <= 10; r++)
        {
            CoinGenerate();
        }
    }

    void Update()
    {

    }

    public void CoinGenerate()
    {
        float x = Random.Range(XRangeMin, XRangeMax);
        float z = Random.Range(ZRangeMin, ZRangeMax);
        Vector3 coinPosition = new Vector3(x, Height, z);
        Instantiate(prefabCoin, coinPosition, Quaternion.identity);
    }

}
