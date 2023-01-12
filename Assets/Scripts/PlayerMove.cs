using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자의 좌우 입력에따라 플레이어를 이동하고 싶다.
        // 1. 사용자의 입력에따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 방향이 필요하다.
        //Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);
        // 3. 이동하고 싶다.
        // 구한 방향으로 이동
        //transform.Translate(dir * speed * Time.deltaTime);
        // 등속운동 ( P = P0 + vt)
        transform.position += dir * speed * Time.deltaTime;
    }


}
