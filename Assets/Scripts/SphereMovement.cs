using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public float forwadsOrBack = 0;
    public float lateral = 0;

    public float speed = 30;

    public float maxSpeed = 50;

    public Transform cameraTransform;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        forwadsOrBack = Input.GetAxis("Vertical");
        lateral =  Input.GetAxis("Horizontal");

        Vector3 newDir = cameraTransform.forward;

        float newX = Mathf.Clamp((newDir.x * Time.deltaTime * speed * forwadsOrBack + GetComponent<Rigidbody>().velocity.x +
            (newDir.z * Time.deltaTime * speed * -lateral)) , -maxSpeed, maxSpeed);
        float newZ = Mathf.Clamp((newDir.z * Time.deltaTime * speed * forwadsOrBack + GetComponent<Rigidbody>().velocity.z +
            (newDir.x * Time.deltaTime * speed * -lateral)) , -maxSpeed, maxSpeed);

        GetComponent<Rigidbody>().velocity = new Vector3(newX, GetComponent<Rigidbody>().velocity.y , newZ);

        if(Input.GetKeyUp(KeyCode.R)){
            transform.position = new Vector3(29F, 3.85F, 516.44F);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            
        }
    }
}
