using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;
    public int CastleWallDestoy;
    public GameObject CastlePrefab;
    Rigidbody rb;

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
       
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")
            || collision.gameObject.CompareTag("Tama") || collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);
            PlayerBullet.shotCount -= 1;
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            
            TamaDeadth += 1;
            rb.constraints = RigidbodyConstraints.FreezeRotationX;
            rb.constraints = RigidbodyConstraints.FreezeRotationZ;
            if (TamaDeadth == 2)
            {
                Destroy(TamaPrefab);
                PlayerBullet.shotCount -= 1;
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);
            PlayerBullet.shotCount -= 1;

            SceneManager.LoadScene(0);
        }
        //else if (collision.gameObject.CompareTag("CastleWall"))
        //{
        //    CastleWallDestoy += 1;
        //    if (CastleWallDestoy == 3)
        //    {
        //        Destroy(CastlePrefab);
        //    }
        //}
    }
}
