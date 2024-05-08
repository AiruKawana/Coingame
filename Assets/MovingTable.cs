using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTable : MonoBehaviour
{
    [SerializeField] private float length = 4.0f;
    [SerializeField] private float speed = 3.0f;

    [SerializeField] private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((Mathf.Sin((Time.time) * speed) * length + startPos.x), startPos.y,startPos.z);
    }

}
