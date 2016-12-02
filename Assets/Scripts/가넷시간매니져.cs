using UnityEngine;
using System.Collections;

public class 가넷시간매니져 : MonoBehaviour {
    public static int Ganet=10000;
    public static float remain=GameNetWorkManager.Time;
    public static int A=0, B=0, C=0, D=0;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        remain -= Time.deltaTime;
    }
}
