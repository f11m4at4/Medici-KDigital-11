using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 위로 이동하고 싶다.
// 1. 방향이 필요하다.
// 2. 이동하고 싶다.
public class Bullet : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 방향이 필요하다.
        Vector3 dir = Vector3.up;
        // 2. 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
