using UnityEngine;
using System.Collections;

public class PortalClass : MonoBehaviour {
    public int type=0;
    NotificationsManager NM = null;
    int timeBefDes = 10000;

    void Start() {
        GameObject notmantmp = GameObject.FindGameObjectWithTag("Manager");
        NM = notmantmp.GetComponent<NotificationsManager>();
        NM.AddListener(OnPortalTimeSet,"PortalTimeSet");
        NM.PostNotification("PortalSpawn", type, 0);
        Debug.Log("spwn");
    }

	
	
	
	void Update () {
        if (timeBefDes <= Time.time)
        {
            NM.RemoveListener(OnPortalTimeSet, "PortalTimeSet");
            NM.PostNotification("Destroied",type,0);
            Destroy(gameObject);
        }
	}


    public void OnPortalTimeSet(string E_key, int Param1, int Param2){
        if (timeBefDes>=Param1)
            timeBefDes = Param1 +(int)Time.time ;
    }
}
