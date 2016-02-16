using UnityEngine;
using System.Collections;

public class InputAddPortalBase : MonoBehaviour {

    public GameObject port = null;
    int x = 0;
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0)){
            Vector3 tmp = new Vector3(x, 0, -6);
            Instantiate(port, tmp, Quaternion.identity);
            x += 2; 
        }
	}
}
