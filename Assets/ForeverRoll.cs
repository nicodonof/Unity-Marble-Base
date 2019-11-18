using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForeverRoll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        GetComponent<Rigidbody>().angularVelocity = new Vector3(-1,2,-0.5F); 
    }

    // Update is called once per frame
    void Update(){
        if(Input.anyKey) {
            SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        }
    }
}
