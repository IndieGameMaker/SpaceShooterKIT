using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 총알 생성
            // Instantiate (생성할객체, 위치, 각도)

            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
