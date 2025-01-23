using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonController : MonoBehaviour
{

    public void BasicButton()
    {
        if(MainManager.instance.isSelect==true)
        {
            ChangeMusic(0);
            MainManager.instance.isSelect=false;
            MainManager.instance.playingNow=0;
        }
    }

    public void TutorialGo()
    {
        if(MainManager.instance.isSelect==false)
        {
            ChangeMusic(1);
            MainManager.instance.isSelect=true;
            MainManager.instance.playingNow=1;
        }
        
        else
        {
            SceneManager.LoadScene("TutorialScene");
        }
        
    }



    public void ExitButton()
    {
        MainManager.instance.toStart=true;
    }

    public void SettingButton()
    {
        //TODO-슬라이드 음량조절 캔버스
    }

    public void ChangeMusic(int num)
    {
        MainManager.instance.mainAudios[MainManager.instance.playingNow].Stop();
        MainManager.instance.playingNow = num;
        MainManager.instance.mainAudios[MainManager.instance.playingNow].Play();
    }
}
