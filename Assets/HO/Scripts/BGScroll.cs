using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경을 스크롤 하고 싶다.
// 필요속성 : 머티리얼, 스크롤속도
public class BGScroll : MonoBehaviour
{
    // 필요속성 : 머티리얼, 스크롤속도
    Material bgMat;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        // 1. 게임오브젝트가 있어야한다.
        // 2. Mesh Renderer 컴포넌트가 필요하다.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        // 3. 배경(머티리얼)이 필요하다.
        bgMat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        // 배경을 스크롤 하고 싶다.
        // 2. 스크롤 하고 싶다.
        // m = m0 + vt
        bgMat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
