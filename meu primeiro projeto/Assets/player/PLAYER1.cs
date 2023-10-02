using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER1 : MonoBehaviour
{
    public int velocidade = 10;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out rb);
        Debug.Log("Começou");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Rodando");
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(inputHorizontal,0,inputVertical)* velocidade);
    }
}
