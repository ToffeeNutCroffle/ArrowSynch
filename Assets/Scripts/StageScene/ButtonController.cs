using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ButtonController : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite preesedImage;

    public KeyCode keyToPressR;
    public KeyCode keyToPressL; 

    private static string logFilePath;
    void Awake()
    {
        string directoryPath = @"C:\Users\Home\Documents\GitHub\rhythm_game_test\Assets\Scripts\StageScene\BeatsFolder";
        logFilePath = Path.Combine(directoryPath, "log.txt");
        try
        {
            // 디렉토리 존재 여부 확인 후 생성
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(logFilePath, "");
        }
        catch (Exception e)
        {
            Debug.LogError("로그 파일 초기화 실패: " + e.Message);
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        theSR=GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.pauseOn==false)
        {
            if(Input.GetKeyDown(keyToPressR) || Input.GetKeyDown(keyToPressL))
            {
                theSR.sprite = preesedImage;
                WriteLog();
            }

            if(Input.GetKeyUp(keyToPressL) || Input.GetKeyUp(keyToPressR))
            {
                theSR.sprite = defaultImage;
            }
        }
    }

    public void WriteLog()
    {
        StreamWriter sw = new StreamWriter(logFilePath,true);
        sw.WriteLine($"        StartCoroutine({keyToPressL}(" + string.Format("{0:N2}",GameManager.instance.systemtime-3.6f) + "f));");
        sw.Flush();
        sw.Close();
    }
}
