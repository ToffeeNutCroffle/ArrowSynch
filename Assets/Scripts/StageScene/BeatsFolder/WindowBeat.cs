using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBeat : MonoBehaviour
{

    void Start()
    {
        //이 안에 비트 작성
        //StartCorutine(스폰할노트(시간(int면 숫자만 float면 뒤에 f)));
        StartCoroutine(LeftSpawn(0));
        StartCoroutine(UpSpawn(0.5f));
        StartCoroutine(LeftSpawn(0.9f));
        StartCoroutine(UpSpawn(1.3f));
        StartCoroutine(LeftSpawn(1.6f));
        StartCoroutine(LeftSpawn(1.8f));
        StartCoroutine(UpSpawn(2.2f));
    }
    public IEnumerator LeftSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject LeftArrow = BeatController.instance.PoolLeft.Get();
    }

    public IEnumerator RightSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject RightArrow = BeatController.instance.PoolRight.Get();
    }

    public IEnumerator UpSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject UptArrow = BeatController.instance.PoolUp.Get();
    }

    public IEnumerator DownSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject DownArrow = BeatController.instance.PoolDown.Get();
    }

    
    public IEnumerator GameOver(float time)
    {
        yield return new WaitForSeconds(time);
        GameManager.instance.ResultUI();
    }
}
