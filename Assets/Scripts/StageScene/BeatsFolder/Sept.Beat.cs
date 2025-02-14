using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeptBeat : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RightArrow(0.17f));
        StartCoroutine(UpArrow(0.77f));
        StartCoroutine(LeftArrow(1.12f));
        StartCoroutine(DownArrow(1.47f));
        StartCoroutine(DownArrow(1.80f));
        StartCoroutine(LeftArrow(2.02f));
        StartCoroutine(RightArrow(2.86f));
        StartCoroutine(UpArrow(3.20f));
        StartCoroutine(DownArrow(3.56f));
        StartCoroutine(LeftArrow(3.91f));
        StartCoroutine(RightArrow(4.12f));


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
