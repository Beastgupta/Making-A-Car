using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour {

    float aPosition = 1.5f;
    Vector3 startPosition;
    public GameObject otherObject;
    private Vector3 otherPosition = new Vector3(3f, 0, 0);

	// Use this for initialization
	void Start () {
        startPosition = new Vector3(aPosition, 0, 0);
        this.transform.position = startPosition;
        otherObject.transform.position = otherPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
