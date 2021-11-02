using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayerController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(4, 2, 0);
    public float speedToLook = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
    }

    public void LookAt()
    {
        Quaternion newRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, speedToLook * Time.deltaTime);
    }


}
