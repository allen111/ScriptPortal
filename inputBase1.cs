using UnityEngine;
using System.Collections;

public class inputBase1 : MonoBehaviour {
    bool enter = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonUp("use")&& enter){
            Debug.Log("input");
            
        }
        if (Input.GetMouseButtonUp(0) && enter)
        {
            Debug.Log("input0");

        }

    }

    void OnTriggerEnter(Collider other){
        Debug.Log("entered");
        enter = true;
        
    }
    void OnTriggerExit(Collider other) {
        Debug.Log("exited");
        enter = false;


    }

}




