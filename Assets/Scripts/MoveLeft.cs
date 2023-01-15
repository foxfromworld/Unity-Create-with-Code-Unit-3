using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (playerControllerScript.gameOver == false) {
            //transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (playerControllerScript.doubleSpeed)
                transform.Translate(Vector3.left * speed * 2 * Time.deltaTime);
            else
                transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")) { 
            Destroy(gameObject);
        }
    }
}
