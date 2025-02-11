using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Logger : MonoBehaviour
{
    // Start is called before the first frame update
    private static string logFilePath;
    private static StreamWriter logWriter;

    void Awake()
    {
        // 로그 파일 경로 설정
        string directoryPath = @"C:\Users\Home\Documents\GitHub\rhythm_game_test\Assets\Scripts\StageScene\BeatsFolder";
        logFilePath = Path.Combine(directoryPath, "log.txt");
        try
        {
            // 디렉토리 존재 여부 확인 후 생성
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // StreamWriter 생성 (덮어쓰기 X, 이어쓰기 O)
            logWriter = new StreamWriter(logFilePath, true);
            logWriter.AutoFlush = true;

            // 로그 이벤트 등록
            Application.logMessageReceived += LogCallback;
        }
        catch (Exception e)
        {
            Debug.LogError("로그 파일 초기화 실패: " + e.Message);
        }
    }

    void OnDestroy()
    {
        // 로그 이벤트 해제 및 파일 닫기
        Application.logMessageReceived -= LogCallback;
        if (logWriter != null)
        {
            logWriter.Close();
            logWriter = null;
        }
    }
    
    private void LogCallback(string logString, string stackTrace, LogType type)
    {
        if (logWriter != null)
        {
            logWriter.WriteLine($"[{DateTime.Now:HH:mm:ss}] {logString}");
        }
    }

}
