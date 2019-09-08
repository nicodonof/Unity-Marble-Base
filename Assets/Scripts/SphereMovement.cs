using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public float accX = 0;
    public float accY = 0;

    public float speed = 20;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        accX =  Input.GetAxis("Horizontal");
        accY = Input.GetAxis("Vertical");

        float newX = (accX * Time.deltaTime * speed + GetComponent<Rigidbody>().velocity.x);
        float newZ = (accY * Time.deltaTime * speed + GetComponent<Rigidbody>().velocity.z);

        GetComponent<Rigidbody>().velocity = new Vector3(newX, GetComponent<Rigidbody>().velocity.y , newZ);
    }
}
