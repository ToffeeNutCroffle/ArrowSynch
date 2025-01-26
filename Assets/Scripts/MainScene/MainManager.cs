using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public AudioSource[] mainAudios;
    public int playingNow;
    public bool isSelect=false; 
    public bool toStart=false;
    public KeyCode exit; 
    public GameObject exitUI;

    //For Debug
    public int check=0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        mainAudios[0].Play();
    }

    void Update()
    {        
        ExitUIManage();
        CheckExit();
    }

    public void CheckExit()
    {
        if(Input.GetKeyDown(exit) && (isSelect==true))
        {
            if(toStart==false) ButtonColorManager.instance.SetColorBright();   
            mainAudios[playingNow].Stop();
            playingNow=0;
            mainAudios[playingNow].Play();
            isSelect=false;
        }
    }

    public void ExitUIManage()
    {
        if((toStart==true) && Input.GetKeyDown(exit) && (isSelect==false))
        {
            toStart=false;
            exitUI.SetActive(toStart);
        }

        else if((toStart==false) && Input.GetKeyDown(exit) && (isSelect==false))
        {
            toStart=true;
            exitUI.SetActive(toStart);
        }

    }
    


}
