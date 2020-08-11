using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakingStuff : MonoBehaviour {

    public GameObject snowman;
    public Transform snowmanSpawnPoint;

	// Use this for initialization
	void Start ()
    {
        Instantiate(snowman, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(snowman, snowmanSpawnPoint.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
