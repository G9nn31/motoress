using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class moedat : MonoBehaviour
{
    public int velocidadeGiro = 150;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Destroy(gameObject);
        }
    }
    //Update is called once per frame 
    void Update(){
        
    transform.Rotate(Vector3.forward * velocidadeGiro * Time.deltaTime);
    
    }

} 