using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IADamageTerra : MonoBehaviour
{
    public int lives = 10;
    public Animator anim;
    public GameObject HeartCoin;
    public Transform dragaoTerra;
    void Start()
    {
        anim.SetBool("Die", false);
    }
    void Update()
    {
        if (lives <= 0)
        {
            Destroy(gameObject);
            anim.SetBool("Die", true);
            Instantiate(HeartCoin, dragaoTerra.position + Vector3.up * 2, Quaternion.identity);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerProjectile"))
        {
            lives--;
            //iastar.Damage();
            anim.SetTrigger("Damage");
            return;
        }
    }
    public void ExplosionDamage()
    {
        lives = -1;
    }
}