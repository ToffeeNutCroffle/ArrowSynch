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
    public KeyCode exit; 
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        mainAudios[0].Play();
    }

    void Update()
    {
        CheckExit();
    }

    public void CheckExit()
    {
        if(Input.GetKeyDown(exit) && (isSelect==false))
        {
            SceneManager.LoadScene("StartScene");
        }

        else if(Input.GetKeyDown(exit) && (isSelect==true))
        {
            mainAudios[playingNow].Stop();
            playingNow=0;
            mainAudios[playingNow].Play();
            isSelect=false;
        }
    }


}
