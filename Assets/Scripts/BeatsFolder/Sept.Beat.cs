using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeptBeat : MonoBehaviour
{
    void Start()
    {
        //이 안에 비트 작성
        //StartCorutine(스폰할노트(시간(int면 숫자만 float면 뒤에 f)));
        StartCoroutine(RightSpawn(0));
        StartCoroutine(DownSpawn(0.9f));
        StartCoroutine(RightSpawn(1.6f)); 
        StartCoroutine(RightSpawn(1.9f));
        StartCoroutine(DownSpawn(2.3f));
        StartCoroutine(LeftSpawn(3));
        StartCoroutine(LeftSpawn(3.4f));
        StartCoroutine(UpSpawn(3.7f));
        StartCoroutine(RightSpawn(4.4f));
        StartCoroutine(DownSpawn(5.2f));

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
