using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(0, 45 * Time.deltaTime, 0);
        // When script is attached to an object it will rotate
    }
}
