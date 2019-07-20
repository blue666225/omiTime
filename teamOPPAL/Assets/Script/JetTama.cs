using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JetTama : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;
    public int CastleWallDestoy;
    public GameObject CastlePrefab;
    public GameObject JetTamaPrefab;

    AudioSource audioSource;
    public AudioClip jetSE;
 
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        TamaDeadth = 0;
        CastleWallDestoy = 0;
        rb = GetComponent<Rigidbody>();

        audioSource.PlayOneShot(jetSE);
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
        if (collision.gameObject.CompareTag("Player")
            || collision.gameObject.CompareTag("Tama") || collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);

        }
        else if (collision.gameObject.CompareTag("wall")|| collision.gameObject.CompareTag("Enemy")|| collision.gameObject.CompareTag("CastleWall") || collision.gameObject.CompareTag("CastleMain"))
        {
            Destroy(TamaPrefab);
        }
    }
}
