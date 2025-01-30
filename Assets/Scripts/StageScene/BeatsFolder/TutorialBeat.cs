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
        StartCoroutine(RightSpawn(0));
        StartCoroutine(RightSpawn(0.44f));
        StartCoroutine(DownSpawn(0.83f));

        StartCoroutine(DownSpawn(1.7f));
        StartCoroutine(DownSpawn(2.13f));
        StartCoroutine(LeftSpawn(2.52f));

        StartCoroutine(LeftSpawn(3.4f));
        StartCoroutine(LeftSpawn(3.82f));
        StartCoroutine(UpSpawn(4.22f));

        StartCoroutine(UpSpawn(5.1f));
        StartCoroutine(UpSpawn(5.5f));
        StartCoroutine(RightSpawn(5.9f));

        StartCoroutine(RightSpawn(6.76f));
        StartCoroutine(RightSpawn(7.20f));
        StartCoroutine(UpSpawn(7.57f));

        StartCoroutine(UpSpawn(8.42f));
        StartCoroutine(UpSpawn(8.86f));
        StartCoroutine(LeftSpawn(9.27f));

        StartCoroutine(LeftSpawn(10.12f));
        StartCoroutine(LeftSpawn(10.55f));
        StartCoroutine(DownSpawn(11.0f));

        StartCoroutine(DownSpawn(11.84f));
        StartCoroutine(DownSpawn(12.23f));
        StartCoroutine(RightSpawn(12.65f));
        //1차변화
        StartCoroutine(RightSpawn(13.6f));
        StartCoroutine(UpSpawn(14.0f));
        StartCoroutine(LeftSpawn(14.4f));
        StartCoroutine(DownSpawn(14.8f));

        StartCoroutine(RightSpawn(15.3f));
        StartCoroutine(UpSpawn(15.7f));
        StartCoroutine(LeftSpawn(16.1f));
        StartCoroutine(DownSpawn(16.5f));

        StartCoroutine(RightSpawn(17.0f));
        StartCoroutine(UpSpawn(17.4f));
        StartCoroutine(LeftSpawn(17.8f));
        StartCoroutine(DownSpawn(18.2f));

        StartCoroutine(RightSpawn(18.7f));
        StartCoroutine(UpSpawn(19.1f));
        StartCoroutine(LeftSpawn(19.5f));
        StartCoroutine(DownSpawn(19.9f));
        //시계
        StartCoroutine(DownSpawn(20.3f));
        StartCoroutine(LeftSpawn(20.7f));
        StartCoroutine(UpSpawn(21.1f));
        StartCoroutine(RightSpawn(21.5f));

        StartCoroutine(DownSpawn(22.0f));
        StartCoroutine(LeftSpawn(22.4f));
        StartCoroutine(UpSpawn(22.8f));
        StartCoroutine(RightSpawn(23.2f));

        StartCoroutine(DownSpawn(23.7f));
        StartCoroutine(LeftSpawn(24.1f));
        StartCoroutine(UpSpawn(24.5f));
        StartCoroutine(RightSpawn(24.9f));

        StartCoroutine(DownSpawn(25.4f));
        StartCoroutine(LeftSpawn(25.8f));
        StartCoroutine(UpSpawn(26.2f));
        StartCoroutine(RightSpawn(26.6f));
        //2차변화
        StartCoroutine(RightSpawn(27.0f));
        StartCoroutine(RightSpawn(27.8f));

        StartCoroutine(RightSpawn(28.7f));
        StartCoroutine(RightSpawn(29.6f));
        StartCoroutine(UpSpawn(30.45f));
        StartCoroutine(LeftSpawn(30.84f));
        StartCoroutine(DownSpawn(31.0f));

        StartCoroutine(UpSpawn(32.1f));
        StartCoroutine(UpSpawn(33.0f));
        StartCoroutine(LeftSpawn(33.8f));
        StartCoroutine(DownSpawn(34.2f));
        StartCoroutine(RightSpawn(34.4f));

        StartCoroutine(LeftSpawn(35.4f));
        StartCoroutine(LeftSpawn(36.3f));
        StartCoroutine(DownSpawn(37.2f));
        StartCoroutine(RightSpawn(37.6f));
        StartCoroutine(UpSpawn(37.8f));

        StartCoroutine(DownSpawn(38.9f));
        StartCoroutine(DownSpawn(39.7f));
        StartCoroutine(RightSpawn(40.6f));
        StartCoroutine(UpSpawn(41.0f));
        StartCoroutine(LeftSpawn(41.26f));

        StartCoroutine(RightSpawn(42.27f));
        StartCoroutine(RightSpawn(43.0f));
        StartCoroutine(DownSpawn(44.0f));
        StartCoroutine(LeftSpawn(44.4f));
        StartCoroutine(UpSpawn(44.57f));

        StartCoroutine(DownSpawn(45.6f));
        StartCoroutine(DownSpawn(46.5f));
        StartCoroutine(LeftSpawn(47.37f));
        StartCoroutine(UpSpawn(47.8f));
        StartCoroutine(RightSpawn(48.0f));

        StartCoroutine(LeftSpawn(49.04f));
        StartCoroutine(LeftSpawn(49.9f));
        StartCoroutine(UpSpawn(50.73f));
        StartCoroutine(RightSpawn(51.14f));
        StartCoroutine(DownSpawn(51.35f));

        StartCoroutine(UpSpawn(52.4f));
        StartCoroutine(UpSpawn(53.27f));
        StartCoroutine(RightSpawn(54.1f));
        StartCoroutine(DownSpawn(54.53f));
        StartCoroutine(LeftSpawn(54.75f));

        StartCoroutine(RightSpawn(55.8f));
        StartCoroutine(RightSpawn(56.6f));
        StartCoroutine(DownSpawn(57.54f));
        StartCoroutine(LeftSpawn(57.92f));
        StartCoroutine(UpSpawn(58.15f));
        //게임 종료
        StartCoroutine(GameOver(64f));
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

    public IEnumerator GameOver(float time)
    {
        yield return new WaitForSeconds(time);
        GameManager.instance.ResultUI();
    }
}
