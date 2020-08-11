
//This script is attached to the Chicken
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //The API is needed to load levels

public class PlayerCollision : MonoBehaviour
{
    GameObject particleSystemPrefab;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other) //This is called any time the Chicken collides with something
    {
       //Animation.Play 
        if (other.gameObject.CompareTag("Vehicle")) //If the object that collided is tagged as a Car
        {
            StartCoroutine(WaitToReload()); //Calls the WaitToReload 
            
        }

        foreach(ContactPoint contact in collision.contacts)
        {

        }

    }
    IEnumerator WaitToReload()
    {
        yield return new WaitForSeconds(1); SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
 