using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour{
    public GameObject player;

    public Vector3 jumpDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnTriggerEnter(Collider other){
        Vector3 aux = other.gameObject.GetComponent<Rigidbody>().velocity;
        other.gameObject.GetComponent<Rigidbody>().velocity = jumpDir;
    }
}
