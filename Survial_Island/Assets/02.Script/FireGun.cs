using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{

    public GameObject bullet;
    public Transform firepos;
    public HandCtrl boolng;
    public AudioSource source;
    public AudioClip bang;
    private float timer;
    public Animation Animation;
    public ParticleSystem muzle;
    void Start()
    {
        boolng = this.gameObject.GetComponent<HandCtrl>();
        timer = Time.time;
        muzle.Stop();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - timer > 0.2f)
            {
                if (boolng.is_runing == false)
                {
                    timer = Time.time;
                    fire();
                    muzle.Play();
                    
                }
                
            }
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            muzle.Stop();
        } 
    }
    

    private void fire()
    {
        Instantiate(bullet, firepos.position, firepos.rotation);
        source.PlayOneShot(bang);
        Animation.Play("fire");
    }
}
