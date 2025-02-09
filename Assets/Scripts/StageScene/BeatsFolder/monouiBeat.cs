using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monouiBeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LeftSpawn(0));
        StartCoroutine(UpSpawn(0.63f));
        StartCoroutine(UpSpawn(0.76f));
        StartCoroutine(LeftSpawn(1.07f));
        StartCoroutine(RightSpawn(1.74f));
        StartCoroutine(DownSpawn(2.08f));
        StartCoroutine(LeftSpawn(2.36f));
        StartCoroutine(LeftSpawn(2.65f));
        StartCoroutine(UpSpawn(2.93f));
        StartCoroutine(UpSpawn(3.04f));
        StartCoroutine(LeftSpawn(3.44f));
       
        StartCoroutine(RightSpawn(4.1f));
        StartCoroutine(UpSpawn(4.65f));
        StartCoroutine(RightSpawn(5.2f));
        StartCoroutine(RightSpawn(5.3f));
        StartCoroutine(UpSpawn(5.6f));
        StartCoroutine(DownSpawn(6.4f));
        StartCoroutine(LeftSpawn(6.67f));
        StartCoroutine(UpSpawn(6.93f));
        StartCoroutine(UpSpawn(7.23f));
        StartCoroutine(RightSpawn(7.47f));
        StartCoroutine(RightSpawn(7.63f));
        StartCoroutine(UpSpawn(7.9f));

        StartCoroutine(DownSpawn(8.7f));
        StartCoroutine(RightSpawn(9.25f));
        StartCoroutine(DownSpawn(9.81f));
        StartCoroutine(DownSpawn(9.93f));
        StartCoroutine(RightSpawn(10.23f));
        StartCoroutine(LeftSpawn(10.94f));
        StartCoroutine(UpSpawn(11.25f));
        StartCoroutine(RightSpawn(11.53f));
        StartCoroutine(RightSpawn(11.82f));
        StartCoroutine(DownSpawn(12.1f));
        StartCoroutine(DownSpawn(12.22f));
        StartCoroutine(RightSpawn(12.55f));

        StartCoroutine(LeftSpawn(13.26f));
        StartCoroutine(DownSpawn(13.83f));
        StartCoroutine(LeftSpawn(14.39f));
        StartCoroutine(LeftSpawn(14.52f));
        StartCoroutine(DownSpawn(14.82f));
        StartCoroutine(UpSpawn(15.5f));
        StartCoroutine(RightSpawn(15.79f));
        StartCoroutine(DownSpawn(16.11f));
        StartCoroutine(DownSpawn(16.37f));
        StartCoroutine(LeftSpawn(16.66f));
        StartCoroutine(LeftSpawn(16.75f));
        StartCoroutine(DownSpawn(17.1f));
        StartCoroutine(RightSpawn(17.77f));

        StartCoroutine(LeftSpawn(18.38f));
        StartCoroutine(RightSpawn(18.96f));
        StartCoroutine(RightSpawn(19.06f));
        StartCoroutine(LeftSpawn(19.34f));
        StartCoroutine(LeftSpawn(20.1f));
        StartCoroutine(RightSpawn(20.37f));
        StartCoroutine(LeftSpawn(20.68f));
        StartCoroutine(LeftSpawn(20.92f));
        StartCoroutine(RightSpawn(21.25f));
        StartCoroutine(RightSpawn(21.36f)); 
        StartCoroutine(LeftSpawn(21.67f));
        StartCoroutine(RightSpawn(22.34f));

        StartCoroutine(UpSpawn(22.95f));
        StartCoroutine(DownSpawn(23.57f));
        StartCoroutine(DownSpawn(23.68f));
        StartCoroutine(UpSpawn(24.0f));
        StartCoroutine(UpSpawn(24.68f));
        StartCoroutine(DownSpawn(24.97f));
        StartCoroutine(UpSpawn(25.25f));
        StartCoroutine(UpSpawn(25.52f));
        StartCoroutine(DownSpawn(25.83f));
        StartCoroutine(DownSpawn(25.96f));
        StartCoroutine(UpSpawn(26.22f)); 
        StartCoroutine(DownSpawn(26.96f));
        //1차변화
        StartCoroutine(UpSpawn(27.54f));
        StartCoroutine(UpSpawn(27.84f));
        StartCoroutine(UpSpawn(28.14f));
        StartCoroutine(UpSpawn(28.44f));
        StartCoroutine(LeftSpawn(28.67f));
        StartCoroutine(LeftSpawn(28.8f));
        StartCoroutine(RightSpawn(29.08f));
        StartCoroutine(RightSpawn(29.52f));

        StartCoroutine(DownSpawn(29.83f));
        StartCoroutine(DownSpawn(30.13f));
        StartCoroutine(DownSpawn(30.43f));
        StartCoroutine(DownSpawn(30.73f));
        StartCoroutine(RightSpawn(30.97f));
        StartCoroutine(RightSpawn(31.1f));
        StartCoroutine(LeftSpawn(31.4f));
        StartCoroutine(LeftSpawn(31.82f));

        StartCoroutine(UpSpawn(32.1f));
        StartCoroutine(UpSpawn(32.4f));
        StartCoroutine(UpSpawn(32.7f));
        StartCoroutine(UpSpawn(33.0f));
        StartCoroutine(RightSpawn(33.23f));
        StartCoroutine(RightSpawn(33.34f));
        StartCoroutine(LeftSpawn(33.66f));
        StartCoroutine(LeftSpawn(34.1f));

        StartCoroutine(DownSpawn(34.4f));
        StartCoroutine(RightSpawn(35f));
        StartCoroutine(UpSpawn(35.5f));
        StartCoroutine(LeftSpawn(36.1f));

        StartCoroutine(DownSpawn(36.7f));
        StartCoroutine(DownSpawn(37.0f));
        StartCoroutine(DownSpawn(37.3f));
        StartCoroutine(DownSpawn(37.6f));
        StartCoroutine(LeftSpawn(37.80f));
        StartCoroutine(LeftSpawn(37.92f));
        StartCoroutine(RightSpawn(38.25f));
        StartCoroutine(RightSpawn(38.7f));

        StartCoroutine(UpSpawn(39.0f));
        StartCoroutine(UpSpawn(39.3f));
        StartCoroutine(UpSpawn(39.6f));
        StartCoroutine(UpSpawn(39.9f));
        StartCoroutine(RightSpawn(40.08f));
        StartCoroutine(RightSpawn(40.19f));
        StartCoroutine(LeftSpawn(40.58f));
        StartCoroutine(LeftSpawn(41.0f));

        StartCoroutine(DownSpawn(41.28f));
        StartCoroutine(DownSpawn(41.58f));
        StartCoroutine(DownSpawn(41.88f));
        StartCoroutine(DownSpawn(42.18f));
        StartCoroutine(LeftSpawn(42.37f));
        StartCoroutine(LeftSpawn(42.50f));
        StartCoroutine(RightSpawn(42.82f));
        StartCoroutine(RightSpawn(43.26f));

        StartCoroutine(UpSpawn(43.55f));
        StartCoroutine(LeftSpawn(44.1f));
        StartCoroutine(DownSpawn(44.68f));
        StartCoroutine(RightSpawn(45.26f));

        StartCoroutine(RightSpawn(45.86f));
        StartCoroutine(RightSpawn(46.40f));

        //2차변화
        StartCoroutine(LeftSpawn(46.9f));
        StartCoroutine(LeftSpawn(47.17f));
        StartCoroutine(DownSpawn(47.5f));
        StartCoroutine(DownSpawn(47.6f));
        StartCoroutine(RightSpawn(47.88f));
        //1-1
        StartCoroutine(RightSpawn(48.6f));
        StartCoroutine(UpSpawn(48.6f));

        StartCoroutine(UpSpawn(49.18f));
        StartCoroutine(UpSpawn(49.45f));
        StartCoroutine(LeftSpawn(49.8f));
        StartCoroutine(LeftSpawn(49.92f));
        StartCoroutine(DownSpawn(50.1f));
        StartCoroutine(DownSpawn(50.2f));
        //1-2
        StartCoroutine(DownSpawn(50.92f));
        StartCoroutine(RightSpawn(50.92f));

        StartCoroutine(RightSpawn(51.5f));
        StartCoroutine(RightSpawn(51.8f));
        StartCoroutine(UpSpawn(52.1f));
        StartCoroutine(UpSpawn(52.22f));
        StartCoroutine(LeftSpawn(52.38f));
        StartCoroutine(LeftSpawn(52.51f));
        //1-3
        StartCoroutine(LeftSpawn(53.25f));
        StartCoroutine(DownSpawn(53.25f));

        StartCoroutine(DownSpawn(53.82f));
        StartCoroutine(DownSpawn(54.1f));
        StartCoroutine(RightSpawn(54.38f));
        StartCoroutine(RightSpawn(54.5f));
        StartCoroutine(UpSpawn(54.81f));
        //1-4
        StartCoroutine(UpSpawn(55.5f));
        StartCoroutine(LeftSpawn(55.5f));

        StartCoroutine(LeftSpawn(56.13f));
        StartCoroutine(LeftSpawn(56.41f));
        StartCoroutine(UpSpawn(56.67f));
        StartCoroutine(UpSpawn(56.77f));
        StartCoroutine(RightSpawn(57.10f));
        //2-1
        StartCoroutine(RightSpawn(57.81f));
        StartCoroutine(DownSpawn(57.81f));

        StartCoroutine(DownSpawn(58.4f));
        StartCoroutine(DownSpawn(58.67f));
        StartCoroutine(LeftSpawn(58.96f));
        StartCoroutine(LeftSpawn(59.08f));
        StartCoroutine(UpSpawn(59.25f));
        StartCoroutine(UpSpawn(59.37f));
        //2-2
        StartCoroutine(UpSpawn(60.10f));
        StartCoroutine(RightSpawn(60.10f));

        StartCoroutine(RightSpawn(60.68f));
        StartCoroutine(RightSpawn(60.95f));
        StartCoroutine(DownSpawn(61.26f));
        StartCoroutine(DownSpawn(61.40f));
        StartCoroutine(LeftSpawn(61.54f));
        StartCoroutine(LeftSpawn(61.66f));
        //2-3
        StartCoroutine(LeftSpawn(62.37f));
        StartCoroutine(UpSpawn(62.37f));

        StartCoroutine(UpSpawn(62.93f));
        StartCoroutine(UpSpawn(63.22f));
        StartCoroutine(RightSpawn(63.51f));
        StartCoroutine(RightSpawn(63.65f));
        StartCoroutine(DownSpawn(63.94f));
        //2-4
        StartCoroutine(DownSpawn(64.67f));
        StartCoroutine(LeftSpawn(64.67f));

        StartCoroutine(UpSpawn(65.24f));
        StartCoroutine(UpSpawn(65.53f));
        StartCoroutine(RightSpawn(65.80f));
        StartCoroutine(RightSpawn(65.93f));
        StartCoroutine(RightSpawn(66.22f));
        //3-1
        StartCoroutine(UpSpawn(66.96f));
        StartCoroutine(RightSpawn(66.96f));

        StartCoroutine(LeftSpawn(67.53f));
        StartCoroutine(LeftSpawn(67.80f));
        StartCoroutine(DownSpawn(68.12f));
        StartCoroutine(DownSpawn(68.21f));
        StartCoroutine(DownSpawn(68.37f));
        StartCoroutine(RightSpawn(68.5f));
        //3-2
        StartCoroutine(LeftSpawn(69.22f));
        StartCoroutine(DownSpawn(69.22f));

        StartCoroutine(RightSpawn(69.78f));
        StartCoroutine(RightSpawn(70.0f));
        StartCoroutine(UpSpawn(70.4f));
        StartCoroutine(UpSpawn(70.51f));
        StartCoroutine(UpSpawn(70.65f));
        StartCoroutine(LeftSpawn(70.79f));
        //3-3
        StartCoroutine(UpSpawn(71.53f));
        StartCoroutine(LeftSpawn(71.53f));

        StartCoroutine(DownSpawn(72.10f));
        StartCoroutine(DownSpawn(72.38f));
        StartCoroutine(LeftSpawn(72.67f));
        StartCoroutine(LeftSpawn(72.80f));
        StartCoroutine(LeftSpawn(73.10f));
        //3-4
        StartCoroutine(DownSpawn(73.81f));
        StartCoroutine(RightSpawn(73.81f));

        StartCoroutine(UpSpawn(74.37f));
        StartCoroutine(UpSpawn(74.66f));
        StartCoroutine(DownSpawn(74.95f));
        StartCoroutine(DownSpawn(75.07f));
        StartCoroutine(DownSpawn(75.40f));
        //4-1
        StartCoroutine(LeftSpawn(76.11f));
        StartCoroutine(RightSpawn(76.11f));

        StartCoroutine(LeftSpawn(76.66f));
        StartCoroutine(LeftSpawn(76.93f));
        StartCoroutine(DownSpawn(77.25f));
        StartCoroutine(DownSpawn(77.35f));
        StartCoroutine(DownSpawn(77.53f));
        StartCoroutine(RightSpawn(77.65f));
        //4-2
        StartCoroutine(RightSpawn(78.37f));
        StartCoroutine(DownSpawn(78.37f));

        StartCoroutine(RightSpawn(78.95f));
        StartCoroutine(RightSpawn(79.23f));
        StartCoroutine(LeftSpawn(79.53f));
        StartCoroutine(LeftSpawn(79.65f));
        StartCoroutine(LeftSpawn(79.81f));
        StartCoroutine(DownSpawn(79.93f));
        //4-3
        StartCoroutine(LeftSpawn(80.66f));
        StartCoroutine(DownSpawn(80.66f));

        StartCoroutine(LeftSpawn(81.25f));
        StartCoroutine(LeftSpawn(81.53f));
        StartCoroutine(RightSpawn(81.8f));
        StartCoroutine(RightSpawn(81.93f));
        StartCoroutine(RightSpawn(82.2f));
        StartCoroutine(DownSpawn(82.93f));
        //마지막
        StartCoroutine(UpSpawn(83.56f));
        StartCoroutine(LeftSpawn(83.56f));
        StartCoroutine(RightSpawn(83.56f));

        StartCoroutine(GameOver(89.4f));

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

    
    public IEnumerator GameOver(float time)
    {
        yield return new WaitForSeconds(time);
        GameManager.instance.ResultUI();
    }
}
