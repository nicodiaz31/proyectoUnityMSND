using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInstatiator : MonoBehaviour
{
    public GameObject prefabBullet;
    public float xSpeed=0.1f;
    public float ySpeed=0.1f;
    public float zSpeed=0.1f;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(xSpeed, ySpeed, zSpeed);
        Instantiate(prefabBullet, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
