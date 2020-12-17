using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public GameObject bullet;
    public Transform firePoint;

    public GameObject smoke;

    private bool isJumping;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //Logica para movimentacao do player
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);

        if(Input.GetKey(KeyCode.Space) && !isJumping)
        {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;
            smoke.SetActive(true); // Ativar fumaca do jetpack
        }

        if(Input.GetKey(KeyCode.Z))
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        
        if(collision.gameObject.tag == "ground")
        {
            isJumping = false;
            smoke.SetActive(false); // Desativar fumaca do jetpack
        }
    }
}
