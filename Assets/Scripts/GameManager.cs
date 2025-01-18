using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public static GameManager instance;
    public int perfect=0;
    public int miss=0;
    public int good=0;
    public int combo=0;
    public int maxCombo=0;
    public float systemtime;
    public float beat;
    public bool gameEnd = false;
    //인게임 UI
    public Text inGameScore;
    public int score=0;

    public KeyCode pause;
    public bool pauseOn=false;

    public Text resultText;

    public GameObject pauseScreen;
    public GameObject resultScreen;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        theMusic.Play();
        Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
       systemtime+=Time.deltaTime;
       CheckPause();
       if(combo>=maxCombo) maxCombo=combo;
       
       if(gameEnd == false) inGameScore.text="Score: "+score+"\nCombo: "+ combo; 
       else inGameScore.text="";

    }

    public void Perfect(float x,float y)
    {
        perfect+=1;
        combo+=1;
        score+=500;
        GameObject Effect = BeatController.instance.PoolPerfect.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,1);
    }
    
    public void Miss(float x, float y)
    {
        miss+=1;
        combo=0;
        GameObject Effect = BeatController.instance.PoolMiss.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,1);
    }

    public void Good(float x, float y)
    {
        good+=1;
        combo+=1;
        score+=300;
        GameObject Effect = BeatController.instance.PoolGood.Get();
        Effect.GetComponent<EffectPool>().death=false;
        Effect.transform.position=new Vector3(0,0,1);
    }

    public void CheckPause()
    {
        if(Input.GetKeyDown(pause) && pauseOn==false)
        {
            theMusic.Pause();            
            Time.timeScale=0;
            pauseOn=true;
            pauseScreen.SetActive(pauseOn);
            Debug.Log("PAUSE!");
        }

        else if(Input.GetKeyDown(pause) && pauseOn==true)
        {
            theMusic.UnPause();
            Time.timeScale=1;
            pauseOn=false;
            pauseScreen.SetActive(pauseOn);
            Debug.Log("RESUME!");
        }
    }

    public void ResultUI()
    {
        gameEnd=true;
        resultText.text="         RESULT\n"+"SCORE : "+GameManager.instance.score+"\nMAX COMBO : "+GameManager.instance.maxCombo+"\nPERFECT : "+GameManager.instance.perfect+
        "\nGOOD : "+GameManager.instance.good+"\nMISS : "+GameManager.instance.miss;
        resultScreen.SetActive(gameEnd);
    }
}