using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerTriangleBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LeftSpawn(0));
        StartCoroutine(LeftSpawn(0.2f));
        StartCoroutine(DownSpawn(0.34f));
        StartCoroutine(RightSpawn(0.72f));
        StartCoroutine(UpSpawn(1.23f));
        StartCoroutine(LeftSpawn(1.38f));
        StartCoroutine(DownSpawn(1.62f));
        StartCoroutine(LeftSpawn(1.71f));
        StartCoroutine(LeftSpawn(1.9f));
        StartCoroutine(DownSpawn(2.1f));
        StartCoroutine(RightSpawn(2.45f));
        StartCoroutine(UpSpawn(2.87f));
        StartCoroutine(LeftSpawn(3.12f));
        StartCoroutine(DownSpawn(3.42f));
        StartCoroutine(LeftSpawn(3.77f));
        StartCoroutine(LeftSpawn(4.13f));
        StartCoroutine(LeftSpawn(4.3f));
        StartCoroutine(DownSpawn(4.47f));
        StartCoroutine(RightSpawn(4.62f));
        StartCoroutine(UpSpawn(4.81f));
        StartCoroutine(LeftSpawn(5.01f));
        StartCoroutine(DownSpawn(5.17f));
        StartCoroutine(LeftSpawn(5.5f));
        StartCoroutine(LeftSpawn(5.67f));
        StartCoroutine(DownSpawn(5.84f));
        StartCoroutine(RightSpawn(6.21f));
        StartCoroutine(UpSpawn(6.72f));
        StartCoroutine(LeftSpawn(6.87f));
        StartCoroutine(DownSpawn(7.1f));
        StartCoroutine(LeftSpawn(7.18f));
        StartCoroutine(LeftSpawn(7.39f));
        StartCoroutine(LeftSpawn(7.57f));
        StartCoroutine(DownSpawn(7.93f));
        StartCoroutine(RightSpawn(8.26f));
        StartCoroutine(UpSpawn(8.60f));
        StartCoroutine(LeftSpawn(8.93f));
        StartCoroutine(DownSpawn(9.26f));
        StartCoroutine(LeftSpawn(9.61f));
        StartCoroutine(LeftSpawn(9.77f));
        StartCoroutine(DownSpawn(9.97f));

        StartCoroutine(RightSpawn(10.10f));
        StartCoroutine(UpSpawn(10.31f));
        StartCoroutine(LeftSpawn(10.48f));
        StartCoroutine(DownSpawn(10.65f));
        StartCoroutine(LeftSpawn(10.82f));
        StartCoroutine(LeftSpawn(10.98f));
        StartCoroutine(LeftSpawn(11.13f));
        StartCoroutine(DownSpawn(11.33f));
        StartCoroutine(RightSpawn(11.69f));
        StartCoroutine(UpSpawn(12.17f));
        StartCoroutine(LeftSpawn(12.33f));
        StartCoroutine(DownSpawn(12.57f));
        StartCoroutine(LeftSpawn(12.65f));
        StartCoroutine(LeftSpawn(12.85f));
        StartCoroutine(DownSpawn(13.03f));
        StartCoroutine(RightSpawn(13.38f));
        StartCoroutine(UpSpawn(13.77f));
        StartCoroutine(LeftSpawn(14.07f));
        StartCoroutine(DownSpawn(14.40f));
        StartCoroutine(LeftSpawn(14.74f));
        StartCoroutine(LeftSpawn(15.09f));
        StartCoroutine(LeftSpawn(15.77f));
        StartCoroutine(LeftSpawn(16.11f));
        StartCoroutine(LeftSpawn(16.45f));
        StartCoroutine(LeftSpawn(16.76f));
        StartCoroutine(LeftSpawn(16.90f));
        StartCoroutine(LeftSpawn(17.17f));
        StartCoroutine(LeftSpawn(17.7f));
        StartCoroutine(LeftSpawn(17.88f));
        StartCoroutine(LeftSpawn(18.07f));
        StartCoroutine(LeftSpawn(18.18f));
        StartCoroutine(LeftSpawn(18.37f));
        StartCoroutine(LeftSpawn(18.52f));
        StartCoroutine(LeftSpawn(18.88f));
        StartCoroutine(LeftSpawn(19.22f));
        StartCoroutine(LeftSpawn(19.57f));
        StartCoroutine(LeftSpawn(19.73f));

        StartCoroutine(LeftSpawn(20.07f));
        StartCoroutine(LeftSpawn(20.24f));
        StartCoroutine(LeftSpawn(20.44f));
        StartCoroutine(LeftSpawn(20.58f));
        StartCoroutine(LeftSpawn(21.00f));
        StartCoroutine(LeftSpawn(21.31f));
        StartCoroutine(LeftSpawn(21.66f));
        StartCoroutine(LeftSpawn(21.84f));
        StartCoroutine(LeftSpawn(22.00f));
        StartCoroutine(LeftSpawn(22.33f));
        StartCoroutine(LeftSpawn(22.68f));
        StartCoroutine(LeftSpawn(23.01f));
        StartCoroutine(LeftSpawn(23.36f));
        StartCoroutine(LeftSpawn(23.69f));
        StartCoroutine(LeftSpawn(24.03f));
        StartCoroutine(LeftSpawn(24.38f));
        StartCoroutine(LeftSpawn(24.72f));
        StartCoroutine(LeftSpawn(25.05f));
        StartCoroutine(LeftSpawn(25.39f));
        StartCoroutine(LeftSpawn(25.74f));
        StartCoroutine(LeftSpawn(26.09f));
        StartCoroutine(LeftSpawn(26.42f));
        StartCoroutine(LeftSpawn(26.78f));
        StartCoroutine(LeftSpawn(27.14f));
        StartCoroutine(LeftSpawn(27.47f));
        StartCoroutine(LeftSpawn(27.63f));
        StartCoroutine(LeftSpawn(27.81f));
        StartCoroutine(LeftSpawn(27.97f));
        StartCoroutine(LeftSpawn(28.16f));
        StartCoroutine(LeftSpawn(28.32f));
        StartCoroutine(LeftSpawn(28.48f));
        StartCoroutine(LeftSpawn(28.64f));
        StartCoroutine(LeftSpawn(28.85f));
        StartCoroutine(LeftSpawn(29.02f));
        StartCoroutine(LeftSpawn(29.18f));
        StartCoroutine(LeftSpawn(29.34f));
        StartCoroutine(LeftSpawn(29.55f));
        StartCoroutine(LeftSpawn(29.70f));
        StartCoroutine(LeftSpawn(29.86f));
        StartCoroutine(LeftSpawn(30.00f));
        StartCoroutine(LeftSpawn(30.20f));
        StartCoroutine(LeftSpawn(30.55f));
        StartCoroutine(LeftSpawn(30.90f));
        StartCoroutine(LeftSpawn(31.21f));
        StartCoroutine(LeftSpawn(32.23f));
        StartCoroutine(LeftSpawn(32.92f));

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
