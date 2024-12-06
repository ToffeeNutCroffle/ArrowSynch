using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //for every note, it cost 3.6sec to be PERFECT

        //StartCoroutine(LeftSpawn(0));
        //StartCoroutine(RightSpawn(0));  
        //StartCoroutine(UpSpawn(0));
        StartCoroutine(DownSpawn(0));

    }

    // Update is called once per frame
    void Update()
    {
    }
    
    //코루틴 생성
    public IEnumerator LeftSpawn(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        GameObject LeftArrow = BeatController.instance.PoolLeft.Get();
    }

    public IEnumerator RightSpawn(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        GameObject RightArrow = BeatController.instance.PoolRight.Get();
    }

    public IEnumerator UpSpawn(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        GameObject UptArrow = BeatController.instance.PoolUp.Get();
    }

    public IEnumerator DownSpawn(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        GameObject DownArrow = BeatController.instance.PoolDown.Get();
    }
}
