using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
//BeatController라고 쓰고 풀링매니저라고 읽는다
public class BeatController : MonoBehaviour
{
    public GameObject Arrow;
    public static BeatController instance;
    public int DefaultCapacity = 10;
    public int MaxPoolSize = 15;

    public int EffectCapacity = 7;
    public int MaxEffect = 10;

    public GameObject goodeffect;
    public GameObject perfecteffect;
    public GameObject misseffect;

    //4종류의 pool 정의
    public IObjectPool<GameObject> PoolLeft{get; set;}
    public IObjectPool<GameObject> PoolRight{get; set;}
    public IObjectPool<GameObject> PoolUp{get; set;}
    public IObjectPool<GameObject> PoolDown{get; set;}
    
    //effect pool 생성
    public IObjectPool<GameObject> PoolGood{get; set;}
    public IObjectPool<GameObject> PoolPerfect{get; set;}
    public IObjectPool<GameObject> PoolMiss{get; set;}

    private void Awake()
    {
        if(instance==null) instance=this;
        else Destroy(this.gameObject);

        Init();
    }
    
    private void Init()
    {
        //4종 노트 풀링
        PoolLeft = new ObjectPool<GameObject>(CreateLeft,TakePool,ReturnPool,DestroyObject,
        true, DefaultCapacity,MaxPoolSize);

        PoolRight = new ObjectPool<GameObject>(CreateRight,TakePool,ReturnPool,DestroyObject,
        true, DefaultCapacity,MaxPoolSize);

        PoolUp = new ObjectPool<GameObject>(CreateUp,TakePool,ReturnPool,DestroyObject,
        true, DefaultCapacity,MaxPoolSize);

        PoolDown = new ObjectPool<GameObject>(CreateDown,TakePool,ReturnPool,DestroyObject,
        true, DefaultCapacity,MaxPoolSize);

        //3중 판정 이펙트 풀링
        
        PoolGood = new ObjectPool<GameObject>(CreateGood,TakePool,ReturnPool,DestroyObject,
        true, EffectCapacity,MaxEffect);

        PoolPerfect = new ObjectPool<GameObject>(CreatePefect,TakePool,ReturnPool,DestroyObject,
        true, EffectCapacity,MaxEffect);

        PoolMiss = new ObjectPool<GameObject>(CreateMiss,TakePool,ReturnPool,DestroyObject,
        true, EffectCapacity,MaxEffect);
        
        //NoteController에서 쉽게 풀링으로 접근하기 위해 하는 과정
        for(int i=0; i<DefaultCapacity; i++)
        {
            NoteController noteleft = CreateLeft().GetComponent<NoteController>();
            noteleft.keyToPressL=KeyCode.A;
            noteleft.keyToPressR=KeyCode.LeftArrow;
            noteleft.state = NoteController.Direction.left;
            noteleft.Pool.Release(noteleft.gameObject); 

            NoteController noteright = CreateRight().GetComponent<NoteController>();
            noteright.keyToPressL=KeyCode.D;
            noteright.keyToPressR=KeyCode.RightArrow;
            noteright.state = NoteController.Direction.right;
            noteright.Pool.Release(noteright.gameObject);

            NoteController noteup = CreateUp().GetComponent<NoteController>();
            noteup.keyToPressL=KeyCode.W;
            noteup.keyToPressR=KeyCode.UpArrow;
            noteup.state = NoteController.Direction.up;
            noteup.Pool.Release(noteup.gameObject);

            NoteController notedown = CreateDown().GetComponent<NoteController>();
            notedown.keyToPressL=KeyCode.S;
            notedown.keyToPressR=KeyCode.DownArrow;
            notedown.state = NoteController.Direction.down;
            notedown.Pool.Release(notedown.gameObject);            
        }
        
        for(int j=0; j<EffectCapacity; j++)
        {
            EffectPool misscontroller=CreateMiss().GetComponent<EffectPool>();
            misscontroller.Pool.Release(misscontroller.gameObject);

            EffectPool perfectcontroller=CreatePefect().GetComponent<EffectPool>();
            perfectcontroller.Pool.Release(perfectcontroller.gameObject);

            EffectPool goodcontroller=CreateGood().GetComponent<EffectPool>();
            goodcontroller.Pool.Release(goodcontroller.gameObject);

        }
        
    }   

    private GameObject CreateLeft()
    {
        GameObject poolgo = Instantiate(Arrow, new Vector3(-13,0,-1),Quaternion.Euler(0,180,0));
        poolgo.GetComponent<NoteController>().Pool = this.PoolLeft;
        return poolgo;
    }

    private GameObject CreateRight()
    {
        GameObject poolgo = Instantiate(Arrow, new Vector3(13,0,-1),Quaternion.identity);
        poolgo.GetComponent<NoteController>().Pool = this.PoolRight;
        return poolgo;
    }

    private GameObject CreateUp()
    {
        GameObject poolgo = Instantiate(Arrow, new Vector3(0,13,-1), Quaternion.Euler(0,0,90));
        poolgo.GetComponent<NoteController>().Pool = this.PoolUp;
        return poolgo;
    }

    private GameObject CreateDown()
    {
        GameObject poolgo = Instantiate(Arrow, new Vector3(0,-13,-1), Quaternion.Euler(0,0,270));
        poolgo.GetComponent<NoteController>().Pool = this.PoolDown;
        return poolgo;
    }

    private GameObject CreateGood()
    {
        GameObject poolgo = Instantiate(goodeffect, new Vector3(13,13,-1),Quaternion.identity);
        poolgo.GetComponent<EffectPool>().Pool = this.PoolGood;
        return poolgo;
    }


    private GameObject CreatePefect()
    {
        GameObject poolgo = Instantiate(perfecteffect, new Vector3(13,13,-1),Quaternion.identity);
        poolgo.GetComponent<EffectPool>().Pool = this.PoolPerfect;
        return poolgo;
    }


    private GameObject CreateMiss()
    {
        GameObject poolgo = Instantiate(misseffect, new Vector3(13,13,-1),Quaternion.identity);
        poolgo.GetComponent<EffectPool>().Pool = this.PoolMiss;
        return poolgo;
    }



    private void TakePool(GameObject poolgo)
    {
        poolgo.SetActive(true);
    }

    private void ReturnPool(GameObject poolgo)
    {
        poolgo.SetActive(false);
    }

    private void DestroyObject(GameObject poolgo)
    {
        Destroy(poolgo);
    }

   
}
