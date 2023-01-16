using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð��� �ѹ��� ���� ����� �ʹ�.
// �ʿ�Ӽ� : �����ð�(�����ð�), ����ð�, ������
public class EnemyGod : MonoBehaviour
{
    // �ʿ�Ӽ� : �����ð�(�����ð�),
    public float createTime = 2;
    // ����ð�,
    float currentTime = 0;
    // ������
    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ð��� �ѹ��� ���� ����� �ʹ�.
        // 1. �ð��� �귶���ϱ�
        currentTime += Time.deltaTime;
        // 2. ����(����)�ð��� �����ϱ�
        // -> ���� ����ð��� �����ð��� �ʰ��ϸ�
        if (currentTime > createTime)
        {
            currentTime = 0;
            // 3. ���� ����� �ʹ�.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. ��ġ����
            enemy.transform.position = transform.position;
        }
    }
}
