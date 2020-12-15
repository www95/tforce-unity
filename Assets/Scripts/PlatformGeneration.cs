using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject Platform;
    public Transform point;
    public float Distance;

    private float platformWidth; 

    void Start()
    {
        if(Platform.GetComponent<BoxCollider2D>()){
            platformWidth = Platform.GetComponent<BoxCollider2D>().size.x;

        }else{
            platformWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
    }

    void Update()
    {
        Distance = Random.Range(3f, 8f);

        if(transform.position.x < point.position.x){
            transform.position = new Vector3(transform.position.x + platformWidth + Distance, transform.position.y, transform.position.z);
            Instantiate(Platform, transform.position, transform.rotation);
        }   
    }
}
