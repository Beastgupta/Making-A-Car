//This is the PublicScript
using UnityEngine;
using System.Collections;

public class PublicScript : MonoBehaviour
{
    public string feelings = "Happy";
    public PrivateScript scriptVariable;

    // Use this for initialization
    void Start()
    {
        Debug.Log(feelings);
        scriptVariable.PrintAValue("Loud. Clear.");
    }
        
        public void SetFeelings(string feeling)
    {
        if (feeling == "Sad")
        {
            Debug.Log("I won't let you make me sad.");
        }
        else
        {
            feelings = feeling;
            Debug.Log("My feelings are " + feelings);
        }
    }

    public void CanAccess(string newString)
    {
        feelings = newString;
        Debug.Log("My feelings are now " + feelings);
    }

    private void OnlyWorksInThisScript()
    {
        Debug.Log("I was called from the script I was added to.");
    }
}