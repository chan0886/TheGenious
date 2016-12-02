using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public void ChangeToScene(int Scene_num)
    {
        SceneManager.LoadScene(Scene_num);
    }
}
