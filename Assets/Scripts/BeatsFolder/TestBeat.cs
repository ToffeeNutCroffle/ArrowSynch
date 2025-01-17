using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(LeftSpawn(0));
        // StartCoroutine(DownSpawn(0.4f));
        // StartCoroutine(RightSpawn(0.8f));
        // StartCoroutine(UpSpawn(1.4f));
        // StartCoroutine(LeftSpawn(1.8f));
        // StartCoroutine(DownSpawn(2.2f));
        StartCoroutine(LeftSpawn(0));
        StartCoroutine(LeftSpawn(0.1f));        
        StartCoroutine(LeftSpawn(0.2f));        
        StartCoroutine(LeftSpawn(0.3f));
    }

    // Update is called once per frame
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
