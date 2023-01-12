using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 아래로 이동하고 싶다.
// -> 타겟을 계속 따라다니고 싶다.

public class Enemy : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;
    // 타겟
    public GameObject target;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        int percent = Random.Range(1, 101);
        // 30% 확률로 타겟 방향으로
        // -> 만약 확률이 30% 이하면
        if (percent <= 30)
        {
            //  -> 타겟 방향으로 설정
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 그렇지않으면
        else
        {
            // 그냥 아래로
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //그 방향으로 계속 이동하고 싶다.
        // -> 타겟을 계속 따라다니고 싶다.
        // 2. 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
