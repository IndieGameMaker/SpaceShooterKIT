using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    void Start()
    {
        // Rigidbody 컴포넌트 추출후 변수에 할당
        rb = GetComponent<Rigidbody>();

        // 힘(Force)을 가하는 함수
        rb.AddRelativeForce(Vector3.forward * 1000.0f); // 1000 뉴튼(N)
    }
}
