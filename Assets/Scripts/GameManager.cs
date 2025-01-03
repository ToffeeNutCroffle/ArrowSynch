using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO-일시정지 화면 구현
public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public static GameManager instance;
    public int perfect=0;
    public int miss=0;
    public int good=0;
    public int combo=0;
    public float systemtime;
    public float beat;

    public KeyCode pause;
    public bool pauseOn=false;

    public EffectPool test;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        theMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
       systemtime+=Time.deltaTime;
       CheckPause();
    }

    public void Perfect(float x,float y)
    {
        perfect+=1;
        combo+=1;
        GameObject Effect = BeatController.instance.PoolPerfect.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,-1);
    }
    
    public void Miss(float x, float y)
    {
        miss+=1;
        combo=0;
        GameObject Effect = BeatController.instance.PoolMiss.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,-1);
    }

    public void Good(float x, float y)
    {
        good+=1;
        combo+=1;
        GameObject Effect = BeatController.instance.PoolGood.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,-1);
    }

    public void CheckPause()
    {
        if(Input.GetKeyDown(pause) && pauseOn==false)
        {
            theMusic.Pause();            
            Time.timeScale=0;
            pauseOn=true;
            Debug.Log("PAUSE!");
        }

        else if(Input.GetKeyDown(pause) && pauseOn==true)
        {
            theMusic.UnPause();
            Time.timeScale=1;
            pauseOn=false;
            Debug.Log("RESTART!");
        }
    }

    public IEnumerator MissReturn(GameObject obj)
    {
        yield return new WaitForSeconds(1);
        BeatController.instance.PoolMiss.Release(obj);
    }

    public IEnumerator GoodReturn(GameObject obj)
    {
        yield return new WaitForSeconds(1);
        BeatController.instance.PoolGood.Release(obj);
    }

    public IEnumerator PerfectReturn(GameObject obj)
    {
        yield return new WaitForSeconds(1);
        BeatController.instance.PoolPerfect.Release(obj);
    }
}