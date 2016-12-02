using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameNetWorkManager : MonoBehaviour {
    private const string ip = "119.202.85.189";
    private const int port = 25000;
    private bool useNat = false;
    public int userLimit = 10;
    public static float Time = 600;
    public Text msg;

    public void OnClickStartServer()
    {
        Network.InitializeServer(userLimit, port, useNat);
    }
    public void OnClickConnect()
    {
        Network.Connect(ip, port);
    }
    public void OnClickUserCounter()
    {
        SetMessage("User : " + Network.connections.Length.ToString());
    }

    void SetMessage(string _msg)
    {
        msg.text += _msg + "\n";
    }
    void OnServerInitialized()
    {
        SetMessage("Initialization server");
    }
    void OnPlayerConnected(NetworkPlayer player)
    {
        SetMessage("New Player. IP : " + player.ipAddress);
    }
    void OnPlayerDisconnected(NetworkPlayer payer)
    {
        SetMessage("Player disconnected");
    }



	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
