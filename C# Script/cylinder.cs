using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be placed here
    }

    // Update is called once per frame
    void Update()
    {    
        // Rotate the object around the X-axis at a speed of 200 degrees per second
        transform.Rotate(200 * Time.deltaTime, 0, 0);
    }
}
