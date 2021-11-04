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
        portal = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Player")
        {
            if (sizex2 == false)
            {
                transform.localScale = new Vector3(transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);
                sizex2 = true;
            }
            else
            {
                transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y * 2, transform.localScale.z * 2);
                sizex2 = false;
            }


        }
    }
    
}

