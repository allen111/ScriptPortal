using UnityEngine;
using System.Collections;

public class portalMan : MonoBehaviour {

    int[] TypeQuantity = { 0, 0, 0, 0 };
    int[][] tempDes = new int[4][];
    NotificationsManager NM = null;
    void Awake(){
        NM = GetComponentInParent<NotificationsManager>();
        NM.CreateEvent("PortalSpawn");
        NM.CreateEvent("PortalTimeSet");
        NM.CreateEvent("Destroied");
    }
    void Start() {
        tempDes[0] = new int[] { 60, 30, 15, 5, 0 };
        tempDes[1] = new int[] { 50, 40, 20, 10, 0 };
        tempDes[2] = new int[] { 30, 20, 10, 5, 0 };
        tempDes[3] = new int[] { 20, 10, 5, 2, 0 };

        NM.AddListener(OnPortalSpawn, "PortalSpawn");
        NM.AddListener(OnDestroied, "Destroied");
    }

    public void OnPortalSpawn(string E_key, int Param1, int Param2){
        int type = Param1;
        if (TypeQuantity[type] < tempDes[type].Length)
            TypeQuantity[type]++;
        int quant = TypeQuantity[type];
        int time = tempDes[type][quant];
        NM.PostNotification("PortalTimeSet",time,0);
    }

    public void OnDestroied(string E_key, int Param1, int Param2) {
        Debug.Log("des");
        int type = Param1;
        if (TypeQuantity[type] > 0)
            TypeQuantity[type]--;
        else
            Debug.Log("underZeroExeption");

    }
}
