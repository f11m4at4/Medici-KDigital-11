using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 아래로 이동하고 싶다.
// -> 타겟을 계속 따라다니고 싶다.
// 태어날 때 동적으로 씬(월드)에 있는 게임오브젝트 찾기
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
        // 태어날 때 동적으로 씬(월드)에 있는 게임오브젝트 찾기
        target = GameObject.Find("Player");
        int percent = Random.Range(1, 101);
        // 30% 확률로 타겟 방향으로
        // -> 만약 확률이 30% 이하면
        // -> 그리고 타겟이 없지않다면
        if (percent <= 30 && target != null)
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

    // 다른 물체와 부딪히면 부딪힌녀석 없애고, 나도 죽고싶다
    // 다른 물체와 부딪히면 호출되는 함수
    // -> Callback function, event
    // Enter, Stay, Exit
    // 부딪히면 폭발효과를 발생시키고 싶다.
    // 필요속성 : 폭발공장
    public GameObject explosionFactory;
    private void OnCollisionEnter(Collision other)
    {
        // 폭발공장에서 폭발 만들고,
        GameObject explosion = Instantiate(explosionFactory);
        // 배치하고 싶다.
        explosion.transform.position = transform.position;

        //부딪힌녀석 없애고, 나도 죽고싶다
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
