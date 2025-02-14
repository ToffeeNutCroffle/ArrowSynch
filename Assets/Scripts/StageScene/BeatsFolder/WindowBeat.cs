using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBeat : MonoBehaviour
{

    void Start()
    {
        //이 안에 비트 작성
        //StartCorutine(스폰할노트(시간(int면 숫자만 float면 뒤에 f)));
        StartCoroutine(LeftArrow(0.00f));
    }
    public IEnumerator LeftArrow(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject LeftArrow = BeatController.instance.PoolLeft.Get();
    }

    public IEnumerator RightArrow(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject RightArrow = BeatController.instance.PoolRight.Get();
    }

    public IEnumerator UpArrow(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject UptArrow = BeatController.instance.PoolUp.Get();
    }

    public IEnumerator DownArrow(float time)
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
