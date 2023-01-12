using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� �Ʒ��� �̵��ϰ� �ʹ�.
// -> Ÿ���� ��� ����ٴϰ� �ʹ�.

public class Enemy : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;
    // Ÿ��
    public GameObject target;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        int percent = Random.Range(1, 101);
        // 30% Ȯ���� Ÿ�� ��������
        // -> ���� Ȯ���� 30% ���ϸ�
        if (percent <= 30)
        {
            //  -> Ÿ�� �������� ����
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // �׷���������
        else
        {
            // �׳� �Ʒ���
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�� �������� ��� �̵��ϰ� �ʹ�.
        // -> Ÿ���� ��� ����ٴϰ� �ʹ�.
        // 2. �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
