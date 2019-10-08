using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody rigidbody;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) //can thrust while rotating
        {
            //Debug.Log("Thrusting");
            audio = GetComponent<AudioSource>();
            rigidbody.AddRelativeForce(Vector3.up);
            if(!audio.isPlaying)
            {
                audio.Play();
            }
            
            

        }
        else
        {
            audio.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating Left");
            transform.Rotate(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating Right");
            transform.Rotate(-Vector3.forward);
        }

    }
}
