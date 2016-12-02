using UnityEngine;
using System.Collections;

public class 창고아이템버튼 : MonoBehaviour {
    public GameObject Aimg, Bimg, Cimg, Dimg,Aex,Bex,Cex,Dex;
	// Use this for initialization
	void Start () {
        Aex.SetActive(false);
        Bex.SetActive(false);
        Cex.SetActive(false);
        Dex.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (가넷시간매니져.A == 1)
            Aimg.SetActive(true);
        else
        {
            Aex.SetActive(false);
            Aimg.SetActive(false);
        }

        if (가넷시간매니져.B == 1)
            Bimg.SetActive(true);
        else
        {
            Bex.SetActive(false);
            Bimg.SetActive(false);
        }

        if (가넷시간매니져.C == 1)
            Cimg.SetActive(true);
        else
        {
            Cex.SetActive(false);
            Cimg.SetActive(false);
        }

        if (가넷시간매니져.D == 1)
            Dimg.SetActive(true);
        else
        {
            Dex.SetActive(false);
            Dimg.SetActive(false);
        }

    }

    public void ClickA()
    {
        Aex.SetActive(true);
        Bex.SetActive(false);
        Cex.SetActive(false);
        Dex.SetActive(false);
    }

    public void ClickB()
    {
        Aex.SetActive(false);
        Bex.SetActive(true);
        Cex.SetActive(false);
        Dex.SetActive(false);
    }

    public void ClickC()
    {
        Aex.SetActive(false);
        Bex.SetActive(false);
        Cex.SetActive(true);
        Dex.SetActive(false);
    }

    public void ClickD()
    {
        Aex.SetActive(false);
        Bex.SetActive(false);
        Cex.SetActive(false);
        Dex.SetActive(true);
    }

    public void ClickAex()
    {
        가넷시간매니져.A = 0;
    }

    public void ClickBex()
    {
        가넷시간매니져.B = 0;
    }

    public void ClickCex()
    {
        가넷시간매니져.C = 0;
    }

    public void ClickDex()
    {
        가넷시간매니져.D = 0;
    }
}
