using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class EffectPool : MonoBehaviour
{
    public IObjectPool<GameObject> Pool {get; set;} 
    public float lifetime = 0;
    public bool death=true;

    void Update()
    {
        if(death == false)
        {
            lifetime+=Time.deltaTime;
        }
        ReturnPool();
    }

    public void ReturnPool()
    {
        if(lifetime > 0.5)
        {
            Pool.Release(this.gameObject);
            this.lifetime=0;
            this.death=true;
        }
    }
}





