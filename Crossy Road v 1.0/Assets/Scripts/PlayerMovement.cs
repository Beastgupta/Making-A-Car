using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    private GameObject Tank;
    public Animation anim;
    float step = 0.15f;
    private float tooFarLeft = -30;
    private float tooFarRight = 30;
    bool isKeyRepeating = false;


	// Use this for initialization
	void Start () {
        Tank = this.gameObject.transform.GetChild(0).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, step), Space.World);
            Tank.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-step, 0, 0), Space.World);
    
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -step), Space.World);
            Tank.transform.eulerAngles = new Vector3(0, 270, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(step, 0, 0), Space.World);
            Tank.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if (transform.position.x <= tooFarLeft)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
            
    }
}
