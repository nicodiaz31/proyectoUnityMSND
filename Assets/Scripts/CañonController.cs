using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 sizeToAdd;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootCannon",2f,1.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            for(var i = 0; i < 2; i++)
            {
                Debug.Log("Shoot Bullet number: "+i);
                ShootCannon();
            }
        }
        else if(Input.GetKeyDown(KeyCode.K)){
            for(var i = 0; i < 3; i++)
            {
                Debug.Log("Shoot Bullet number: "+i);
                ShootCannon();
            }
        }
        else if(Input.GetKeyDown(KeyCode.L))
        {
          for(var i = 0; i < 4; i++)
            {
                Debug.Log("Shoot Bullet number: "+i);
                ShootCannon();
            }  
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You are shooting bigger bullets: ");
            ShootBigCannon();

        }

    }

    void ShootCannon()
    {
        Instantiate(bulletPrefab,getGeneratorTransform());
        AudioSource audio= transform.GetChild(2).gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    void ShootBigCannon()
    {
        Transform newTransform = bulletPrefab.transform;
        newTransform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
        Instantiate(bulletPrefab, newTransform);
    }

    Transform getGeneratorTransform()
    {
        GameObject generator = transform.GetChild(1).gameObject;
        return generator.transform;
    }
}
