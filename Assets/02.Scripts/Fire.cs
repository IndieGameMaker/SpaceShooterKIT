#pragma warning disable CS0108

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fire : MonoBehaviour
{
    [SerializeField] private Transform firePos;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private new AudioSource audio;
    [SerializeField] private AudioClip fireSfx;
    [SerializeField] private MeshRenderer muzzleFlash;

    void Start()
    {
        audio = GetComponent<AudioSource>();

        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        muzzleFlash.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }

    }

    void FireBullet()
    {
        // 총알 생성
        // Instantiate (생성할객체, 위치, 각도)
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);

        // 총소리 발생
        audio.PlayOneShot(fireSfx, 0.8f);

        StartCoroutine(ShowMuzzleFlash());
    }

    // 코루틴 (Co-routine function)
    IEnumerator ShowMuzzleFlash()
    {
        // Muzzle Flash Texture Offset 변경
        /*
            Random.Range(mix, max)

            1. 정수
            Random.Range(0, 10) --> 0, 1, 2, ... , 9

            2. 실수
            Random.Range(0.0f, 10.0f) --> 0.0f, ... , 10.0f
        */

        // (0, 0) (0.5, 0) (0, 0.5) (0.5, 0.5)
        // 0, 0.5
        Vector2 offset = new Vector2(Random.Range(0, 2) * 0.5f, Random.Range(0, 2) * 0.5f);
        muzzleFlash.GetComponent<MeshRenderer>().material.mainTextureOffset = offset;

        // MuzzleFlash Scale 변경
        float scale = Random.Range(1.0f, 3.0f);
        muzzleFlash.transform.localScale = Vector3.one * scale;

        muzzleFlash.enabled = true;
        // Waiting (Sleep)
        yield return new WaitForSeconds(0.2f);

        muzzleFlash.enabled = false;
    }
}
