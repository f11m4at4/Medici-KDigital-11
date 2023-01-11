using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 함수이름(인자값);
        int result = Plus(200, 5);
        print(result);
    }

    // 더하기 기능
    // 반환자료형 함수이름( [인수,...] )
    int Plus(int number1, int number2)
    {
        int result = number1 + number2;
        // [return data;]
        return result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
