 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

//TODO-한번에 하나씩만 처리

public class NoteController : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyToPressR;
    public KeyCode keyToPressL;
    public Sprite ArrowSP;
    public float BeatTempo;
    //use for check time
    float time;

    public IObjectPool<GameObject> Pool {get; set;}

    public enum Direction
    {
        none,
        left, 
        right, 
        up, 
        down 
    }

    public Direction state;

    void Start()   
    {
        BeatTempo=BeatTempo/60f;  
        this.GetComponent<SpriteRenderer>().sprite = ArrowSP;
    }

    void Update()
    {   
        if(GameManager.instance.pauseOn==false)
        {
            this.CheckHit();
            switch(state)
            {
                case Direction.up: 
                gameObject.transform.position -= new Vector3(0f, BeatTempo*Time.deltaTime ,0f); break;
            
                case Direction.right: 
                gameObject.transform.position -= new Vector3(BeatTempo*Time.deltaTime, 0f ,0f); break;

                case Direction.left: 
                gameObject.transform.position += new Vector3(BeatTempo*Time.deltaTime, 0f ,0f); break;

                case Direction.down: 
                gameObject.transform.position += new Vector3(0f, BeatTempo*Time.deltaTime ,0f); break;
            }
        }
        time+=Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed=true;
        }

        else if(other.tag == "Destroy")
        { 
            GameManager.instance.Miss(this.transform.position.x, this.transform.position.y);
            ResetPosition(state);
            Pool.Release(this.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag =="Activator")
        {
            canBePressed=false;
        }
    }

    public void CheckHit()
    {
        if(Input.GetKeyDown(keyToPressR) || Input.GetKeyDown(keyToPressL))
        {
            if(canBePressed==true)
            {
                if(this.transform.position.y==0)
                {
                    if(Mathf.Abs(this.transform.position.x) >=2 || Mathf.Abs(this.transform.position.x) <= 1)
                    {
                        GameManager.instance.Miss(this.transform.position.x, 0);
                    }
                    else if(Mathf.Abs(this.transform.position.x) >= 1.7 || Mathf.Abs(this.transform.position.x) <= 1.3)
                    {
                        GameManager.instance.Good(this.transform.position.x, 0);
                    }
                    else
                    {
                        GameManager.instance.Perfect(this.transform.position.x, 0);
                    }
                }

                else if(this.transform.position.x==0)
                {
                    if(Mathf.Abs(this.transform.position.y)>=2 || Mathf.Abs(this.transform.position.y)<=1)
                    {
                        GameManager.instance.Miss(0, this.transform.position.y);
                    }
                    else if(Mathf.Abs(this.transform.position.y) >= 1.7 || Mathf.Abs(this.transform.position.y) <= 1.3)
                    {
                        GameManager.instance.Good(0, this.transform.position.y);
                    }
                    else 
                    {
                        GameManager.instance.Perfect(0, this.transform.position.y);
                    }
                }  
               
                ResetPosition(state);
                Pool.Release(this.gameObject);
                //Debug.Log(time);
                //Debug.Log(GameManager.instance.systemtime);
            }
        }
      
    }

    public void ResetPosition(Direction dir)
    {
        switch(dir)
        {
            case Direction.up: gameObject.transform.position=new Vector3(0,13,1); break;
            case Direction.right: gameObject.transform.position=new Vector3(13,0,1); break;
            case Direction.left: gameObject.transform.position=new Vector3(-13,0,1); break;
            case Direction.down: gameObject.transform.position=new Vector3(0,13,1); break;
        } 
    }
}
