using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 500f;
    public Rigidbody rb;

    void Start()
    {
        // ���� ��ǥ�� ���ǵ� ��ŭ ���ؼ� ������ ������ ���ش�.
        // Vector3 .forward �� �۷ι��� ������ �ǵ��� ������ǥ�� ��ƾ��Ѵ�.
        rb.AddForce(transform.forward * Speed);
        Destroy(this, 3f);
    }
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }



}
