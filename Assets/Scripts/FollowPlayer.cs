using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //private Vector3 offset1 = new Vector3(-1, 17, -24);
    //private Vector3 offset2 = new Vector3(-0.5f, 5.31f, -0.1f);


    public Camera upCamera;
    public Camera driverCamera;


    private void Start()
    {
        upCamera.enabled = true;
        driverCamera.enabled = false;
    }





    /// <summary>
    ///          Problem:Kameranýn kullanýcýyý takip etmesi
    ///          Çözüm:kameranýn konumunu oyuncunun konumuna atayýn
    /// </summary>
    private void LateUpdate()
    {
        //transform.position = player.transform.position + offset1;


        if (Input.GetKeyDown(KeyCode.C))
        {
            upCamera.enabled = !upCamera.enabled;
            driverCamera.enabled = !driverCamera.enabled;
        }
        
    }
}
