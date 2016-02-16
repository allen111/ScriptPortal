using UnityEngine;
using System.Collections;

public class movementMouse1 : MonoBehaviour {
    private bool moving = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
            Vector3 inputPosition = Input.mousePosition;
            //inputPosition.z = 5f ;
            Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(inputPosition.x, inputPosition.y, 2f));
            transform.position = pos;
            Debug.Log("camera"+Camera.main.transform.position.z);
            Debug.Log(transform.position.z);

    }
}
