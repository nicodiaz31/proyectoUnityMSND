using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string playerName = "Nombre de jugador";
    public int playerLives;
    public float playerSpeed = 5.0f;
    public float playerRotationSpeed = 3f;
    private Vector2 characterRotation = new Vector2();
    public bool sizex2 = false;

    // Start is called before the first frame update
    void Start()
    {
        playerName = "Nombre de jugador";
        playerLives = 3;
        Debug.Log("Game starting");
        Debug.Log(transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(xSpeed,ySpeed,zSpeed);
        MovePlayer();
        RotatePlayer();
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
        float ejeHorizontal = Input.GetAxisRaw("Horizontal");
        float ejeVertical = Input.GetAxisRaw("Vertical");
        
        transform.Translate(playerSpeed * Time.deltaTime * new Vector3(ejeHorizontal, 0, ejeVertical));

        AudioSource audio = transform.GetChild(2).gameObject.GetComponent<AudioSource>();

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            audio.UnPause();
        }
        else
        {
            audio.Pause();
        }

    }
    void RotatePlayer()
    {
        characterRotation.x +=  Input.GetAxis("Mouse X") * playerRotationSpeed;
        characterRotation.y += Input.GetAxis("Mouse Y") * playerRotationSpeed;
        Quaternion rotation= Quaternion.Euler(-characterRotation.y, characterRotation.x, 0);
        transform.localRotation = Quaternion.Euler(-characterRotation.y, characterRotation.x, 0);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "DarkPortal")
        {
            Debug.Log(collision.gameObject.name + "No contiene shrinker");
        }
        else
        {
            Debug.Log(collision.gameObject.tag + "contiene shrinker");

        }


    }

}
