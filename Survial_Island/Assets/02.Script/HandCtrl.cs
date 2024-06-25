using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCtrl : MonoBehaviour
{
    public Animation ComBatAim; //  �ִϸ��̼�
    public Light GunLight; // �� �ķ���
    public AudioClip flash; // mp4
    public AudioSource A_source; // ����� �ҽ�
    public bool is_runing =false;
    //�浹����
    
    void Start() //  ���� ������ �ٷ� �����Լ�
    {

    }


    void Update() //  ���� ���� �� ��� ȣ���ϴ� �Լ�
    {
        Gun();
        FlashLight();
    }

    private void Gun()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
        {
            ComBatAim.Play("running");// �ִϸ��̼� ����
            is_runing = true;

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            ComBatAim.Play("runStop");
            is_runing = false;
        }
       

    }

    private void FlashLight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GunLight.enabled = !GunLight.enabled;
            // �Ҹ� ���� �Ҹ������� �Բ� �ѹ��� ���
            A_source.PlayOneShot(flash, 1.0f);

        }
    }   
}
