using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName="Nombre de jugador";  
    public int playerLives;
    public float playerSpeed = 100.0f;
    public float xSpeed=0.1f;
    public float ySpeed=0.0f;
    public float zSpeed=0.0f;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        playerName="Nombre de jugador";
        playerLives=3;
        Debug.Log("Game starting");
        Debug.Log(transform.position);
        transform.position = new Vector3(-15,2,1);
        transform.localScale= new Vector3(1,1,1);
        direction = new Vector3(xSpeed, ySpeed, zSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(xSpeed,ySpeed,zSpeed);
        MovePlayer(direction);
    }

    void ReloadOneLife()
    {
        playerLives++;
    }

    void ReloadMaxLives()
    {
        playerLives = 3;
    }

    void LostLife()
    {
        playerLives--;
    }

    void MovePlayer(Vector3 movement)
    {
        transform.Translate(playerSpeed*Time.deltaTime*movement);
    }
}
