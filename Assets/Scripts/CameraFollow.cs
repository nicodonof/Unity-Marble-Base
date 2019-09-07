using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        GetComponent<Transform>().position = player.GetComponent<Transform>().position - new Vector3(0,-4.5F,10);
        // GetComponent<Transform>().position = player.GetComponent<Transform>(). - new Vector3(10,-10,10);
    }
}
