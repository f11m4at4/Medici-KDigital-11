using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �Լ��̸�(���ڰ�);
        int result = Plus(200, 5);
        print(result);
    }

    // ���ϱ� ���
    // ��ȯ�ڷ��� �Լ��̸�( [�μ�,...] )
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
