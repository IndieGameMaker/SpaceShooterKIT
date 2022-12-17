using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    // 충돌 감지 Collision Dectection
    // 1. 양쪽 모두 Collider 컴포넌트
    // 2. 이동하는 개체에는 반드시 Rigidbody 컴포넌트가 존재해야 한다.

    /*
        - Is Trigger 언체크일 경우

            void OnCollisionEnter() --- 1
            void OnCollisionStay() --- n
            void OnCollisionExit() --- 1

        
        - Is Trigger 체크일 경우
            void OnTriggerEnter() --- 1
            void OnTriggerStay() --- n
            void OnTriggerExit() --- 1
  
    */

    private void OnCollisionEnter(Collision other)
    {
        // GC
        // if (other.collider.tag == "BULLET")
        // {}

        if (other.collider.CompareTag("BULLET"))
        {
            Destroy(other.gameObject);
        }
    }

}

/*
    AudioListener --> 1 존재

    AudioSource --> n 

*/

/*
    하늘 표현 방식

    1. 6 Sided Sky
    2. Sky Dome
    3. Procedural Sky

    4. HDRP - Volumatric Sky

*/
