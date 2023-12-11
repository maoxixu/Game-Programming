using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class success : MonoBehaviour
{
    // Start is called before the first frame update
    // ...

    void OnCollisionEnter(Collision other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.gameObject.tag == "Player")
        {
            // Load the "success" scene when the player collides with this object
            SceneManager.LoadScene("success");
        }
    }

   
}
