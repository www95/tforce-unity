using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Update is called once per frame
    public float Speed;


    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
