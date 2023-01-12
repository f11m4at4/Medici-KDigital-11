using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ���� �̵��ϰ� �ʹ�.
// 1. ������ �ʿ��ϴ�.
// 2. �̵��ϰ� �ʹ�.
public class Bullet : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. ������ �ʿ��ϴ�.
        Vector3 dir = Vector3.up;
        // 2. �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
