using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public static GameManager instance;
    public int perfect=0;
    public int miss=0;
    public int normal=0;
    public int combo=0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        theMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
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
        normal+=1;
        combo+=1;
    }
}