using UnityEngine;
using System.Collections;

public class PostEx : MonoBehaviour {
    NotificationsManager NM = null;

	void Awake () {
        NM = GetComponentInParent<NotificationsManager>();
        NM.CreateEvent("eventoProva");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("g")){
            NM.PostNotification("eventoProva", 0, 0);
            Debug.Log("eventoProva 0 0");
        }
	}
}
