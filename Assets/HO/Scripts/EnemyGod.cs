using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 만들고 싶다.
// 필요속성 : 일정시간(생성시간), 경과시간, 적공장
public class EnemyGod : MonoBehaviour
{
    // 필요속성 : 일정시간(생성시간),
    public float createTime = 2;
    // 경과시간,
    float currentTime = 0;
    // 적공장
    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 일정시간에 한번씩 적을 만들고 싶다.
        // 1. 시간이 흘렀으니까
        currentTime += Time.deltaTime;
        // 2. 일정(생성)시간이 됐으니까
        // -> 만약 경과시간이 생성시간을 초과하면
        if (currentTime > createTime)
        {
            currentTime = 0;
            // 3. 적을 만들고 싶다.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. 위치지정
            enemy.transform.position = transform.position;
        }
    }
}
