using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Manager : NetworkManager {

    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
