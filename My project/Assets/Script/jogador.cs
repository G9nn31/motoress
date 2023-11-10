using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jogador : MonoBehaviour
{
    public int forcaPulo = 7;
    public int velocidade = 10;
    private Rigidbody rb;

    public bool noChao = false;
    
    private void Start(){
        TryGetComponent(out rb);
    }
    private void OnCollisionEnter(Collision collision)
    {        
        noChao = true;
    }
    private void Update(){
        float h = Input.GetAxis("Horizontal"); //-1 esquerda,0 nada, 1 direita
        float v = Input.GetAxis("Vertical");// -1 pra tras, 0 nada, 1 pra frente
        rb.AddForce(new Vector3(h,0,v)* velocidade * Time.deltaTime,ForceMode.Impulse);
        //pulo
        if (noChao && Input.GetKeyDown(KeyCode.Space))
        {                     
            rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
            noChao = false;
        }
        //reiniciando cena quando jogador cai
        if (transform.position.y <= -10)
        {            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
