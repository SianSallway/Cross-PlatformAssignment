using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] float speed;
    float verticalMovement;
    float horizontalMovement;
    Vector3 movement;
    [SerializeField] Rigidbody rigidbody;

	
	// Update is called once per frame
	void Update ()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");

        if (Input.GetKey("up"))
        {
            rigidbody.MovePosition((Vector3)rigidbody.position + Vector3.forward * verticalMovement * speed * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            rigidbody.MovePosition((Vector3)rigidbody.position - Vector3.back * verticalMovement * speed * Time.deltaTime);
        }

        if (Input.GetKey("right"))
        {
            rigidbody.MovePosition((Vector3)rigidbody.position + Vector3.right * horizontalMovement * speed * Time.deltaTime);
        }

        if (Input.GetKey("left"))
        {
            rigidbody.MovePosition((Vector3)rigidbody.position - Vector3.left * horizontalMovement * speed * Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            rigidbody.MovePosition((Vector3)rigidbody.position + Vector3.up * speed * Time.deltaTime);
        }

    }
}