using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomCoin : MonoBehaviour
{
    [SerializeField] private GameObject prefabCoin;

    [SerializeField] private TextMeshProUGUI MyCoins;

    [SerializeField] private int coinCount = 5;

    [SerializeField] private GameObject gameOverText;

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

        MyCoins.text = "My Coin:" + coinCount;

        gameOverText.SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (coinCount > 0)
            {
                CoinGenerate();
                coinCount -= 1;
            }

            if(coinCount == 0)
            {
                gameOverText.SetActive(true);
            }
        }

        MyCoins.text = "My Coin:" + coinCount;
    }

    public void CoinGenerate()
    {
        float x = Random.Range(XRangeMin, XRangeMax);
        float z = Random.Range(ZRangeMin, ZRangeMax);
        Vector3 coinPosition = new Vector3(x, Height, z);
        Instantiate(prefabCoin, coinPosition, Quaternion.identity);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Debug.Log(coinCount);
            coinCount += 1;
            Destroy(collision.gameObject);
        }
    }

}
