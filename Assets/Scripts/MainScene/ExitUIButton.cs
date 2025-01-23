using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitUIButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void CheckButton()
    {
        SceneManager.LoadScene("StartScene");
    }
    
    public void CancelButton()
    {
        MainManager.instance.toStart=false;
    }
}
