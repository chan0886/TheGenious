using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class 시간초 : MonoBehaviour {
    int sec;
    Text label;
    // Use this for initialization
    void Start () {
        label = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        sec = ((int)가넷시간매니져.remain) % 60;
        label.text = sec.ToString();
    }
}
