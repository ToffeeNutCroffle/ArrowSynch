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
    public float Beat;

    public KeyCode pause;
    public bool pauseOn=false;
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

    public void Perfect()
    {
        perfect+=1;
        combo+=1;
    }
    
    public void Miss()
    {
        miss+=1;
        combo=0;
    }

    public void Normal()
    {
        good+=1;
        combo+=1;
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
}