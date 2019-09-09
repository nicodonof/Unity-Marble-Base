using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerScript : MonoBehaviour{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    }

    private void OnTriggerEnter(Collider other){
        text.GetComponent<Counter>().won = true;

    }
}
