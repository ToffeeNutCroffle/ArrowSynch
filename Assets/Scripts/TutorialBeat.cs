using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Every Coroutine have to start from 1
//this may not be right i decide to use time, not real tome
//TODO-뭐하긴 비트깎아야지

public class TutorialBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LeftSpawn(1));
        StartCoroutine(RightSpawn(1.3f));
        StartCoroutine(UpSpawn(2));
        StartCoroutine(DownSpawn(2.7f));
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        //코루틴 생성
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
}
