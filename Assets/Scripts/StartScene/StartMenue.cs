using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//TODO-OpuionButton의 음량 조절 UI 구현

public class StartMenue : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OptionButton()
    {
        //TODO-슬라이드 음량조절 캔버스
    }   

    public void ExitButton()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
