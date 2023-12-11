using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newhit : MonoBehaviour
{
    // Start is called before the first frame update
    // ...

    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Change the color to green when hit by the player
            GetComponent<MeshRenderer>().material.color = Color.green;
            // Change the tag of the object to "Hit"
            gameObject.tag = "Hit";
        }
    }

  
}
