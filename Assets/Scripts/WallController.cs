using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    float timer;
    int rotacion;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        rotacion = 45;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {

                transform.position = new Vector3(transform.position.x - 10, transform.position.y , transform.position.z+5);
                transform.localRotation = Quaternion.Euler(transform.localRotation.x, transform.localRotation.y + rotacion, transform.localRotation.z );
                rotacion += rotacion;
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        timer = 0;
        
    }
}
