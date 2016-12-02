using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class 시간분 : MonoBehaviour {
    Text label;
    int min;
    // Use this for initialization
    void Start () {
        label = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        min = ((int)가넷시간매니져.remain)/ 60;
        label.text = min.ToString();

    }
}
