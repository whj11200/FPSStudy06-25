using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light StairLgiht;
    public AudioSource source;
    public AudioClip clip;
    public AudioClip Exitclip;

    void Start()
    {
        
    }
    // is_Trigger ���� �� �浹�����ϴ� �Լ�
    // �ݺ��Լ���� ������ ��
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // �浹�� 
            StairLgiht.enabled = true;

            source.PlayOneShot(clip,1.5f);
        }
    }
    // �浹���� ����� ������ �Լ�
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // �浹���� ��� �� 
            StairLgiht.enabled = false;
            source.PlayOneShot(clip,1.0f);
        }
    }
    void Update()
    {
        
    }
}
