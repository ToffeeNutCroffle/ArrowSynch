using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeptBeat : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RightArrow(0.00f));
        StartCoroutine(UpArrow(0.77f));
        StartCoroutine(LeftArrow(1.13f));
        StartCoroutine(DownArrow(1.49f));
        StartCoroutine(DownArrow(1.86f));
        StartCoroutine(LeftArrow(2.04f));
        StartCoroutine(RightArrow(2.86f));
        StartCoroutine(UpArrow(3.23f));
        StartCoroutine(DownArrow(3.60f));
        StartCoroutine(LeftArrow(3.95f));
        StartCoroutine(RightArrow(4.14f));
        StartCoroutine(UpArrow(5.73f));
        StartCoroutine(DownArrow(6.43f));
        StartCoroutine(DownArrow(6.77f));
        StartCoroutine(LeftArrow(7.14f));
        StartCoroutine(RightArrow(7.53f));
        StartCoroutine(UpArrow(7.69f));
        StartCoroutine(DownArrow(8.53f));
        StartCoroutine(LeftArrow(8.88f));
        StartCoroutine(RightArrow(9.25f));
        StartCoroutine(LeftArrow(9.59f));
        StartCoroutine(DownArrow(9.98f));
        StartCoroutine(UpArrow(10.65f));
        StartCoroutine(LeftArrow(11.38f));
        StartCoroutine(UpArrow(12.08f));
        StartCoroutine(RightArrow(12.47f));
        StartCoroutine(UpArrow(12.80f));
        StartCoroutine(DownArrow(13.14f));
        StartCoroutine(LeftArrow(13.32f));
        StartCoroutine(LeftArrow(14.15f));
        StartCoroutine(UpArrow(14.53f));
        StartCoroutine(DownArrow(14.90f));
        StartCoroutine(LeftArrow(15.24f));
        StartCoroutine(UpArrow(15.44f));
        StartCoroutine(DownArrow(15.79f));
        StartCoroutine(RightArrow(15.90f));
        StartCoroutine(UpArrow(16.29f));
        StartCoroutine(DownArrow(16.65f));
        StartCoroutine(LeftArrow(16.92f));
        StartCoroutine(UpArrow(17.02f));
        StartCoroutine(RightArrow(17.72f));
        StartCoroutine(DownArrow(18.06f));
        StartCoroutine(UpArrow(18.45f));
        StartCoroutine(LeftArrow(19.15f));
        StartCoroutine(LeftArrow(19.50f));
        StartCoroutine(DownArrow(19.86f));
        StartCoroutine(RightArrow(20.21f));
        StartCoroutine(UpArrow(20.55f));
        StartCoroutine(UpArrow(21.28f));
        StartCoroutine(DownArrow(21.98f));
        StartCoroutine(RightArrow(22.65f));
        StartCoroutine(RightArrow(23.36f));
        StartCoroutine(UpArrow(24.08f));
        StartCoroutine(DownArrow(24.44f));
        StartCoroutine(LeftArrow(24.65f));
        StartCoroutine(LeftArrow(24.97f));
        StartCoroutine(LeftArrow(25.10f));
        StartCoroutine(DownArrow(25.32f));
        StartCoroutine(DownArrow(25.49f));
        StartCoroutine(RightArrow(25.81f));
        StartCoroutine(UpArrow(26.17f));
        StartCoroutine(DownArrow(26.42f));
        StartCoroutine(LeftArrow(26.72f));
        StartCoroutine(UpArrow(26.90f));
        StartCoroutine(LeftArrow(27.18f));
        StartCoroutine(UpArrow(27.47f));
        StartCoroutine(RightArrow(27.78f));
        StartCoroutine(DownArrow(28.23f));
        StartCoroutine(LeftArrow(28.58f));
        StartCoroutine(DownArrow(29.02f));
        StartCoroutine(RightArrow(29.72f));
        StartCoroutine(RightArrow(30.06f));
        StartCoroutine(UpArrow(30.25f));
        StartCoroutine(LeftArrow(30.61f));
        StartCoroutine(RightArrow(30.77f));
        StartCoroutine(DownArrow(30.93f));
        StartCoroutine(LeftArrow(31.10f));
        StartCoroutine(RightArrow(31.48f));
        StartCoroutine(LeftArrow(31.86f));
        StartCoroutine(DownArrow(32.20f));
        StartCoroutine(RightArrow(32.58f));
        StartCoroutine(UpArrow(33.25f));
        StartCoroutine(DownArrow(33.98f));
        StartCoroutine(DownArrow(34.30f));
        StartCoroutine(LeftArrow(34.66f));
        StartCoroutine(RightArrow(35.00f));
        StartCoroutine(UpArrow(35.37f));
        StartCoroutine(DownArrow(35.74f));
        StartCoroutine(RightArrow(35.92f));
        StartCoroutine(UpArrow(36.25f));
        StartCoroutine(LeftArrow(36.76f));
        StartCoroutine(LeftArrow(36.92f));
        StartCoroutine(DownArrow(37.11f));
        StartCoroutine(LeftArrow(37.47f));
        StartCoroutine(DownArrow(37.74f));
        StartCoroutine(RightArrow(38.01f));
        StartCoroutine(DownArrow(38.18f));
        StartCoroutine(UpArrow(38.91f));
        StartCoroutine(UpArrow(39.62f));
        StartCoroutine(UpArrow(39.93f));
        StartCoroutine(UpArrow(40.29f));
        StartCoroutine(LeftArrow(40.67f));
        StartCoroutine(UpArrow(41.01f));
        StartCoroutine(RightArrow(41.38f));
        StartCoroutine(UpArrow(41.56f));
        StartCoroutine(DownArrow(41.91f));
        StartCoroutine(LeftArrow(42.27f));
        StartCoroutine(UpArrow(42.43f));
        StartCoroutine(RightArrow(42.61f));
        StartCoroutine(RightArrow(42.77f));
        StartCoroutine(UpArrow(43.10f));
        StartCoroutine(LeftArrow(43.38f));
        StartCoroutine(UpArrow(43.64f));
        StartCoroutine(DownArrow(43.82f));
        StartCoroutine(RightArrow(44.54f));
        StartCoroutine(UpArrow(44.88f));
        StartCoroutine(LeftArrow(45.24f));
        StartCoroutine(DownArrow(45.98f));
        StartCoroutine(UpArrow(46.66f));
        StartCoroutine(RightArrow(47.02f));
        StartCoroutine(DownArrow(47.40f));
        StartCoroutine(LeftArrow(48.07f));
        StartCoroutine(UpArrow(48.41f));
        StartCoroutine(DownArrow(48.76f));
        StartCoroutine(LeftArrow(48.99f));
        StartCoroutine(UpArrow(49.29f));
        StartCoroutine(LeftArrow(49.48f));
        StartCoroutine(UpArrow(49.76f));
        StartCoroutine(LeftArrow(50.05f));
        StartCoroutine(UpArrow(50.35f));
        StartCoroutine(RightArrow(50.86f));
        StartCoroutine(RightArrow(51.24f));
        StartCoroutine(RightArrow(51.58f));
        StartCoroutine(DownArrow(51.94f));
        StartCoroutine(RightArrow(52.30f));
        StartCoroutine(UpArrow(53.05f));
        StartCoroutine(LeftArrow(53.74f));
        StartCoroutine(LeftArrow(54.06f));
        StartCoroutine(LeftArrow(54.42f));
        StartCoroutine(RightArrow(54.76f));
        StartCoroutine(LeftArrow(55.14f));
        StartCoroutine(DownArrow(55.85f));
        StartCoroutine(RightArrow(56.58f));
        StartCoroutine(RightArrow(56.94f));
        StartCoroutine(UpArrow(57.26f));
        StartCoroutine(DownArrow(57.61f));
        StartCoroutine(UpArrow(57.95f));
        StartCoroutine(LeftArrow(58.64f));
        StartCoroutine(UpArrow(58.98f));
        StartCoroutine(DownArrow(59.38f));
        StartCoroutine(UpArrow(59.73f));
        StartCoroutine(LeftArrow(60.06f));
        StartCoroutine(UpArrow(60.41f));
        StartCoroutine(LeftArrow(60.78f));
        StartCoroutine(DownArrow(61.14f));
        StartCoroutine(RightArrow(61.48f));
        StartCoroutine(UpArrow(62.20f));
        StartCoroutine(UpArrow(62.54f));
        StartCoroutine(DownArrow(62.91f));
        StartCoroutine(UpArrow(63.25f));
        StartCoroutine(LeftArrow(63.62f));
        StartCoroutine(LeftArrow(63.98f));
        StartCoroutine(RightArrow(64.31f));
        StartCoroutine(LeftArrow(64.66f));
        StartCoroutine(RightArrow(65.02f));
        StartCoroutine(RightArrow(65.37f));
        StartCoroutine(DownArrow(65.72f));
        StartCoroutine(LeftArrow(66.10f));
        StartCoroutine(DownArrow(66.43f));
        StartCoroutine(DownArrow(66.78f));
        StartCoroutine(RightArrow(67.13f));
        StartCoroutine(UpArrow(67.81f));
        StartCoroutine(UpArrow(68.17f));
        StartCoroutine(RightArrow(68.54f));
        StartCoroutine(DownArrow(68.89f));
        StartCoroutine(UpArrow(69.26f));
        StartCoroutine(UpArrow(69.62f));
        StartCoroutine(LeftArrow(69.97f));
        StartCoroutine(DownArrow(70.34f));
        StartCoroutine(DownArrow(70.70f));
        StartCoroutine(DownArrow(71.04f));
        StartCoroutine(LeftArrow(71.38f));
        StartCoroutine(DownArrow(71.69f));
        StartCoroutine(DownArrow(72.06f));
        StartCoroutine(DownArrow(72.41f));
        StartCoroutine(RightArrow(72.78f));
        StartCoroutine(DownArrow(73.10f));
        StartCoroutine(RightArrow(73.49f));
        StartCoroutine(RightArrow(73.85f));
        StartCoroutine(UpArrow(74.22f));
        StartCoroutine(LeftArrow(74.57f));
        StartCoroutine(LeftArrow(74.90f));
        StartCoroutine(LeftArrow(75.24f));
        StartCoroutine(DownArrow(75.60f));
        StartCoroutine(RightArrow(75.97f));
        StartCoroutine(LeftArrow(76.33f));
        StartCoroutine(LeftArrow(76.66f));
        StartCoroutine(UpArrow(77.01f));
        StartCoroutine(RightArrow(77.35f));
        StartCoroutine(DownArrow(77.70f));
        StartCoroutine(RightArrow(78.06f));
        StartCoroutine(UpArrow(78.42f));
        StartCoroutine(LeftArrow(79.12f));
        StartCoroutine(RightArrow(79.49f));
        StartCoroutine(LeftArrow(79.81f));
        StartCoroutine(UpArrow(80.16f));
        StartCoroutine(LeftArrow(80.51f));
        StartCoroutine(UpArrow(80.87f));
        StartCoroutine(UpArrow(81.22f));
        StartCoroutine(RightArrow(81.57f));
        StartCoroutine(DownArrow(81.95f));
        StartCoroutine(DownArrow(82.31f));
        StartCoroutine(LeftArrow(82.65f));
        StartCoroutine(DownArrow(82.99f));
        StartCoroutine(RightArrow(83.38f));
        StartCoroutine(RightArrow(83.73f));
        StartCoroutine(LeftArrow(84.06f));
        //게임 종료
        StartCoroutine(GameOver(89.00f));

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
