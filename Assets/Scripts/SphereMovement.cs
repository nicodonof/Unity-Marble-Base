using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public float accX = 0;
    public float accY = 0;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        accY = Input.GetAxis("Vertical");
        accX =  Input.GetAxis("Horizontal");

        float newX = Mathf.Clamp(accX + GetComponent<Rigidbody>().velocity.x,-10,10);
        float newY = Mathf.Clamp(accY + GetComponent<Rigidbody>().velocity.z,-10,10);

        GetComponent<Rigidbody>().velocity = new Vector3(newX, GetComponent<Rigidbody>().velocity.y , newY);
    }
}
