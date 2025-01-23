using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayDown : MonoBehaviour
{
    float MaxRay=3.5f;
    public LayerMask layermask;
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,new Vector3(0,-1,0)* MaxRay, new Color(0,1,0));
        RaycastHit2D hit = Physics2D.Raycast(transform.position,new Vector3(0,-1,1), MaxRay, layermask);      
        if(hit.collider != null)
        {       
            hit.transform.GetComponent<NoteController>().isFirst=true;
        }

    }
}
