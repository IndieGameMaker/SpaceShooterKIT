using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0, 0, 0.01f);
        transform.Translate(Vector3.forward * 0.01f);
    }

    /*
        Vector3(x, y, z)
    */
}
