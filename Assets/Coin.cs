using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Table")
        {
            transform.SetParent(other.transform);
            //this.gameObject.transform.parent = GameObject.Find("Table").transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Table")
        {
            transform.SetParent(null);
            //this.gameObject.transform.DetachChildren();
        }
    }
}
