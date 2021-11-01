using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName="Nombre de jugador";  
    public int playerLives;
    public float playerSpeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerName="Nombre de jugador";
        playerLives=3;
        Debug.Log("Game starting");
        Debug.Log(transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(xSpeed,ySpeed,zSpeed);
        MovePlayer();
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

    void MovePlayer()
    {
        AudioSource audio = transform.GetChild(2).gameObject.GetComponent<AudioSource>();

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(playerSpeed * Time.deltaTime * Vector3.forward);
            
            audio.UnPause();
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(playerSpeed * Time.deltaTime * Vector3.back);
            audio.UnPause();
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(playerSpeed * Time.deltaTime * Vector3.left);
            audio.UnPause();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(playerSpeed * Time.deltaTime * Vector3.right);
            audio.UnPause();
        }
        else
        {
            audio.Pause();
        }

    }

    
}
