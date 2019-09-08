using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private Vector3 _cameraOffset;
    
    public float rotSpeed = 5F;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        GetComponent<Transform>().position = player.GetComponent<Transform>().position - new Vector3(0,-4.5F,10);

        Quaternion camturnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime, Vector3.up);

        _cameraOffset = camturnAngle * _cameraOffset;

        GetComponent<Transform>().LookAt(player.transform);
    }
}
