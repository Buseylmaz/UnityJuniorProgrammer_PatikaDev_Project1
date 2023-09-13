using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*----------- Oyuncunun hareket etmesi için yollar
     * 
     * 1.Transform.Translate ile Hareket Ettirme:
     * 
     * 2.Rigidbody ile Fizik Tabanlý Hareket:
     * 
     */

    [SerializeField] private float playerSpeed;
    [SerializeField] private float playerTurnSpeed;
    float horizontalInput;
    float verticalInput;



    /// <summary>
    /// 
    ///         Sorun:Aracý ileri doðru hareket ettirin
    ///         Sorun:Aracý sag ve sola  hareket ettirin
    ///         
    /// </summary>
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //transform.Translate(0, 0, 1);

        //her saniye de playerSpeed kadar hareket ediyor.
        transform.Translate(Vector3.forward*playerSpeed*Time.deltaTime*verticalInput);
        transform.Rotate(Vector3.up ,playerTurnSpeed * Time.deltaTime*horizontalInput); //up=y

    }



}
