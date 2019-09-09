using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 _cameraOffset;
    private float smoothFactor = 0.5F;
    public float rotSpeed = 75F;

    // Start is called before the first frame update
    void Start(){
        _cameraOffset = transform.position - playerTransform.position;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate(){
        // GetComponent<Transform>().position = playerTransform.position - new Vector3(0,-4.5F,10);

        // Camera angle 
        Quaternion camturnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime, Vector3.up);
        _cameraOffset = camturnAngle * _cameraOffset;

        Vector3 newPos = playerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(playerTransform.position, newPos, smoothFactor);
        transform.LookAt(playerTransform);
    }
}