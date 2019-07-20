using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerTama : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;
    public int CastleWallDestoy;
    public GameObject CastlePrefab;
    public BossWallHp bossWallHp;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        TamaDeadth = 0;
        CastleWallDestoy = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity.normalized);
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("PlayerTama") || collision.gameObject.CompareTag("EnemyTama")
            || collision.gameObject.CompareTag("Tama") || collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);
            PlayerBullet.shotCount -= 1;
        }
        else if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("FragileWall"))
        {
            TamaDeadth += 1;
            if (TamaDeadth == 2)
            {
                Destroy(TamaPrefab);
                PlayerBullet.shotCount -= 1;
            }
        }
        else if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("CastleWall") || collision.gameObject.CompareTag("Boss"))
        {
            PlayerBullet.shotCount -= 1;
            Destroy(TamaPrefab);
        }
        //else if (collision.gameObject.CompareTag("CastleWall"))
        //{
        //    PlayerBullet.shotCount -= 1;
        //    Destroy(TamaPrefab);
        //    bossWallHp.hpSlider.value -= 40f;
        //    if (bossWallHp.hpSlider.value <= 0)
        //    {
        //        Destroy(CastlePrefab);
        //        //Destroy(this.bossWallHp.hpSlider);
        //        Instantiate(bossWallHp.Bossslider, transform.position, transform.rotation);
        //    }
        //}
    }
}
