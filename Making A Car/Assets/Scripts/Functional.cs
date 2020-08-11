using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functional : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //Function(4, 13);
        //Function(2, 12);
        int functionValue = myFunction(7, 19);
        Debug.Log(functionValue);
        if(GreaterThanTen(functionValue))
        {
            Debug.Log("It's bigger than 10!");
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    int myFunction(int one, int two)
    {
        int a = one;
        int b = two;
        return a + b;
    }

    bool GreaterThanTen(int number)
    {
        if (number > 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
