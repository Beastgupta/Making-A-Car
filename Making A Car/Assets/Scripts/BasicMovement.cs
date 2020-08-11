using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

    public int speed = 10;
    Vector3 moveVector = new Vector3(1, 0, 0);

    // Use this for initialization
    void Start()
    {
        if (speed < 10)
        {
            Debug.Log("You're too slow bro!");
        }
        else if (!(speed == 25))
        {
            Debug.Log("Speed isn't 25...");
        }
        else
        {
            Debug.Log("Speeeeeeed!!!"); 
        }
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(moveVector * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
