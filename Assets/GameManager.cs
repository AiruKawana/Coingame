using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private RandomCoin rundomCoin;
    [SerializeField] private TextMeshProUGUI MyCoins;
    [SerializeField] private int coinCount = 5;
    [SerializeField] private GameObject gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        MyCoins.text = "My Coin:" + coinCount;

        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (coinCount > 0)
            {
                rundomCoin.CoinGenerate();
                coinCount -= 1;
            }

            if (coinCount == 0)
            {
                gameOverText.SetActive(true);
            }
        }

        MyCoins.text = "My Coin:" + coinCount;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCount += 1;
            Destroy(collision.gameObject);
        }
    }
}
