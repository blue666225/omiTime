using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    public float seconds;
    public GameObject Smp;

    //追加
    //AudioSource audioSource;
    //public AudioClip enemyShotSE;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        if (seconds >= 2)
        {
            Shot();
       
            Instantiate(Smp, transform.position, transform.rotation);
            seconds = 0;
        }

    }

    void Shot()
    {
        //audioSource.PlayOneShot(enemyShotSE);
        GameObject Tama = Instantiate(TamaPrefab, transform.position, transform.rotation);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
    }
}
