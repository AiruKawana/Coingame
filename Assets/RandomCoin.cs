using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomCoin : MonoBehaviour
{
    public GameObject Coin;

    public TextMeshProUGUI MyCoins;

    public int Coincount = 5;

    public GameObject GameOvertext;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 coinPosition = new Vector3(-1.575412f, 4.0f, 3.198478f);
        for (int r = 1; r <= 10; r++)
        {
            CoinGenerate();
        }

        MyCoins.text = "My Coin:" + Coincount;

        GameOvertext.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (Coincount > 0)
            {
                CoinGenerate();
                Coincount -= 1;
            }

            if(Coincount == 0)
            {
                GameOvertext.SetActive(true);
            }

            MyCoins.text = "My Coin:" + Coincount;
        }
    }

    public void CoinGenerate()
    {
        float x = Random.Range(-1.575412f, -1.6f);
        float z = Random.Range(3.198478f, 3.2f);
        Vector3 coinPosition = new Vector3(x, 6.0f, z);
        Instantiate(Coin, coinPosition, Quaternion.identity);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            Coincount += 1;
        }
    }

}
