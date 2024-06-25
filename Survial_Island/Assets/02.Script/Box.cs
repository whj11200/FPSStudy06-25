using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject OMG;
    public AudioSource source;
    public AudioClip ahop;

    void Start()
    {
        
    }

   
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="Bullet")
        {
            var box =Instantiate(OMG,col.transform.position,Quaternion.identity);
            source.PlayOneShot(ahop, 1.0f);
            Destroy(box, 2.0f);
        }
       
    }
}
