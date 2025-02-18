using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f;
    public float turnSpeed = 20.0f;
    public float xRange = 7;
    public float yRange = 9;

    // Update is called once per frame
    void Update() 
        {
            if (transform.position.x > xRange)
            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.x < -xRange)
            {
               transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }
            if (transform.position.y > yRange)
            {
                transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
            }
            if (transform.position.y < -yRange)
            {
                transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
            }
            {
                horizontalInput = Input.GetAxis("Horizontal");
                verticalInput = Input.GetAxis("Vertical");

                transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
                //transform.Translate(Vector3.down * Time.deltaTime * speed * verticalInput);
                transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
                //transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);
            }
        }
    }
