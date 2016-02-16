using UnityEngine;
using System.Collections;

public class ListenEx : MonoBehaviour {
    private NotificationsManager NM = null;

	
	void Start () {
        NM = GetComponentInParent<NotificationsManager>();
        NM.AddListener(OnEvProva, "eventoProva");
	}


    void OnEvProva(string E_key, int Param1, int Param2) {
        Debug.Log("event recived yuppi yeah");
    }
}
