using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �ε����� �༮�� �� �׿������ڴ�!!!
public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
