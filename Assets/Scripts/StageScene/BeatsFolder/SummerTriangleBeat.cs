using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerTriangleBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpSpawn(0));
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
