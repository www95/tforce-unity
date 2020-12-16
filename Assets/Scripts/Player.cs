using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    public  float JumpForce;

    public GameObject bullet;

    public Transform firePoint;

    public GameObject smoke;

    private Rigidbody2D rig;
    private bool isJumping;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);

        if(Input.GetKey(KeyCode.Space) && !isJumping){
            
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;
            smoke.SetActive(true);

        }

        if(Input.GetKey(KeyCode.Z)){
            
            Instantiate(bullet, firePoint.transform.position,  firePoint.transform.rotation);
        }
    }


    void OnCollisionEnter2D(Collision2D  collision){
        if(collision.gameObject.layer == 8){
            isJumping = false;
            smoke.SetActive(false);
        }
    }
}
