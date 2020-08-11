//This is the PrivateScript
using UnityEngine;
using System.Collections;

public class PrivateScript : MonoBehaviour
{

    private string feelingOverride = "Sad";
    PublicScript theScript;

    // Use this for initialization
    void Start()
    {
        theScript = Camera.main.GetComponent<PublicScript>();
        theScript.SetFeelings("Content");
    }

    void OnMouseDown()
    {
        theScript.CanAccess(feelingOverride);
    }

    public void PrintAValue(string value)
    {
        Debug.Log(value);
    }
}