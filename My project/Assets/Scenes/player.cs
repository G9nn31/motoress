using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "START");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "UPDATE");
    }
}
