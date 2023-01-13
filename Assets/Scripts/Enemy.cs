using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� �Ʒ��� �̵��ϰ� �ʹ�.
// -> Ÿ���� ��� ����ٴϰ� �ʹ�.
// �¾ �� �������� ��(����)�� �ִ� ���ӿ�����Ʈ ã��
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
        // �¾ �� �������� ��(����)�� �ִ� ���ӿ�����Ʈ ã��
        target = GameObject.Find("Player");
        int percent = Random.Range(1, 101);
        // 30% Ȯ���� Ÿ�� ��������
        // -> ���� Ȯ���� 30% ���ϸ�
        // -> �׸��� Ÿ���� �����ʴٸ�
        if (percent <= 30 && target != null)
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

    // �ٸ� ��ü�� �ε����� �ε����༮ ���ְ�, ���� �װ�ʹ�
    // �ٸ� ��ü�� �ε����� ȣ��Ǵ� �Լ�
    // -> Callback function, event
    // Enter, Stay, Exit
    // �ε����� ����ȿ���� �߻���Ű�� �ʹ�.
    // �ʿ�Ӽ� : ���߰���
    public GameObject explosionFactory;
    private void OnCollisionEnter(Collision other)
    {
        // ���߰��忡�� ���� �����,
        GameObject explosion = Instantiate(explosionFactory);
        // ��ġ�ϰ� �ʹ�.
        explosion.transform.position = transform.position;

        //�ε����༮ ���ְ�, ���� �װ�ʹ�
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
