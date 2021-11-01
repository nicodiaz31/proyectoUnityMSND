using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject mainCam;
    GameObject secondaryCam;
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        secondaryCam = GameObject.FindGameObjectWithTag("Camera2");
    }

    void Update()
    {

          if (Input.GetKeyDown(KeyCode.X))
            {

            if(mainCam.activeSelf==true)
            {
                mainCam.SetActive(false);
                secondaryCam.SetActive(true);
            }
            else
            {
                mainCam.SetActive(true);
                secondaryCam.SetActive(false);
            }
            
        }

        
    }
   
}
