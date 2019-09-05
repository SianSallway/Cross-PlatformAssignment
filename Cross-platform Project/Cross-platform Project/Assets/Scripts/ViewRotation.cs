using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeiwRotation : MonoBehaviour
{
    public GameObject player;
    public float sensitiviy;
    float rotateHorizontal;
    float rotateVertical;

    // Update is called once per frame
    void Update()
    {
        rotateHorizontal = Input.GetAxis("Mouse X");
        rotateVertical = Input.GetAxis("Mouse Y");

        transform.Rotate(-transform.up * rotateHorizontal * sensitiviy);

        transform.Rotate(transform.right * rotateVertical * sensitiviy);
    }
}
