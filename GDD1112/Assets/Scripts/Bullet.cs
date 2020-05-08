using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed=20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,bulletSpeed*Time.deltaTime);
    }
}
