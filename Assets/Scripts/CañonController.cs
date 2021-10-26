using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonController : MonoBehaviour
{
    public GameObject bulletPrefab;
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
        }}

    void ShootCannon()
    {
        Instantiate(bulletPrefab,transform);
    }
}
