using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public float count = 0F;
    public bool won = false;
    private float startTime;
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.anyKey && startTime == 0){
            startTime = Time.timeSinceLevelLoad;
        }
        if(!won && startTime != 0) {
            count = Time.timeSinceLevelLoad - startTime;
            transform.GetComponent<TMPro.TextMeshProUGUI>().text = count.ToString();
        }
        if (Input.GetKeyUp(KeyCode.R)){
            startTime = 0;
            won = false;
        }
    }
}
