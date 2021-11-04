using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    Rigidbody player;
    GameObject player1;
    Rigidbody portal;
    public bool sizex2 = false;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.Find("Player").GetComponent<Rigidbody>();
        player1 = GameObject.FindGameObjectWithTag("Player");
        portal = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Cylinder.007")
        {
            if (sizex2 == false)
            {

                player1.transform.localScale = new Vector3(player1.transform.localScale.x / 2, player1.transform.localScale.y / 2, player1.transform.localScale.z / 2);
                sizex2 = true;
            }
            else
            {
                player1.transform.localScale = new Vector3(player1.transform.localScale.x * 2, player1.transform.localScale.y * 2, player1.transform.localScale.z * 2);
                sizex2 = false;
            }


        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    
}

