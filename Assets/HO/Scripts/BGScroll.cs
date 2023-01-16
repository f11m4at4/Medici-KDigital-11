using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� ��ũ�� �ϰ� �ʹ�.
// �ʿ�Ӽ� : ��Ƽ����, ��ũ�Ѽӵ�
public class BGScroll : MonoBehaviour
{
    // �ʿ�Ӽ� : ��Ƽ����, ��ũ�Ѽӵ�
    Material bgMat;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        // 1. ���ӿ�����Ʈ�� �־���Ѵ�.
        // 2. Mesh Renderer ������Ʈ�� �ʿ��ϴ�.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        // 3. ���(��Ƽ����)�� �ʿ��ϴ�.
        bgMat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        // ����� ��ũ�� �ϰ� �ʹ�.
        // 2. ��ũ�� �ϰ� �ʹ�.
        // m = m0 + vt
        bgMat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
