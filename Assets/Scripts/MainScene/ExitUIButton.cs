using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitUIButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void CheckButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    
    public void CancelButton()
    {
        MainManager.instance.toStart=false;
        MainManager.instance.exitUI.SetActive(false);
    }

    void Update()
    {
        
    }
}
