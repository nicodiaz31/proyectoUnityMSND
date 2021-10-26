using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float timeToKillBullet;
    private float timeUntilKillBullet;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
        checkTimers();

    }

    void MoveBullet()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }

    void checkTimers()
    {
        timeToKillBullet -= Time.deltaTime;
        if (timeToKillBullet <= 0)
        {
            DestroyBullet();
        }
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    //TODO: Check for changeSize in bullet Controller
    //void ChangeSize()
    //{
      //  transform.localScale += new Vector3(0.2f,0.2f,0.2f);  
    //}
}
