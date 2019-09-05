using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //public GameObject player;
    public float speed;
    float rotateHorizontal;
    float rotateVertical;

    // Update is called once per frame
    void Update()
    {
        rotateHorizontal = Input.GetAxis("Horizontal");
        rotateVertical = Input.GetAxis("Vertical");
        Vector3 v3 = new Vector3(rotateVertical, rotateHorizontal, 0.0f);

        if(Input.GetKey("w") || Input.GetKey("d") || Input.GetKey("s") || Input.GetKey("a"))
        {
            transform.Rotate(v3 * speed * Time.deltaTime);
        }



        /*if(Input.GetKey("w"))
        {
            //transform.Rotate(transform.up * rotateVertical * sensitiviy);
            //transform.Translate(new Vector3(0, sensitiviy * Time.deltaTime, 0));
        }

        if(Input.GetKey("s"))
        {
            //transform.Rotate(-transform.up * rotateVertical * sensitiviy);
            //transform.Translate(new Vector3(0, -sensitiviy * Time.deltaTime, 0));
        }

        if (Input.GetKey("d"))
        {
            //transform.Rotate(transform.right * rotateHorizontal * sensitiviy);
            //transform.Translate(new Vector3(sensitiviy * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey("a"))
        {
            //transform.Rotate(-transform.right * rotateHorizontal * sensitiviy);
            //transform.Translate(new Vector3(-sensitiviy * Time.deltaTime, 0, 0));
        }*/




    }
}
