﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public float accX = 0;
    public float accY = 0;

    public float speed = 1000;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        accY = Input.GetAxis("Vertical");
        accX =  Input.GetAxis("Horizontal");

        float newX = Mathf.Clamp((accX * Time.deltaTime + GetComponent<Rigidbody>().velocity.x),-speed,speed);
        float newY = Mathf.Clamp((accY * Time.deltaTime + GetComponent<Rigidbody>().velocity.z),-speed,speed);

        GetComponent<Rigidbody>().velocity = new Vector3(newX, GetComponent<Rigidbody>().velocity.y , newY);
    }
}
