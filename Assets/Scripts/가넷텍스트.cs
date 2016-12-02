using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class 가넷텍스트 : MonoBehaviour {
    Text Gnum;
    // Use this for initialization
    void Start () {
        Gnum = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Gnum.text = 가넷시간매니져.Ganet.ToString();
    }
}
