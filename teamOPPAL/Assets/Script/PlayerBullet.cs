using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float shotTime;
    public GameObject TamaPrefab;
    public static int shotCount;
    public GameObject Smp;
    AudioSource audioSource;
    public AudioClip plShotSE;//追加

    // Start is called before the first frame update
    void Start()
    {
        shotCount = 0;
        audioSource = GetComponent<AudioSource>();////追加
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Shot"))
        {
            if (shotCount < 5)
            {
                Shot();
                Instantiate(Smp, transform.position, transform.rotation);
            }
        }       
    }

    void Shot()
    {
        GameObject Tama = Instantiate(TamaPrefab, transform.position,transform.rotation);
        Rigidbody tamarigidbody = Tama.GetComponent<Rigidbody>();
        tamarigidbody.AddForce(transform.forward * shotTime);
        shotCount += 1;

        //音再生
        audioSource.PlayOneShot(plShotSE);
        
    }
}
