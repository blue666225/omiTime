using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
   
    public Vector3 direction;
    public float speed;
    public float Rotate_speed;
    private GameObject Houtou;

    AudioSource audioSource;
    public AudioClip moveSE;

    Rigidbody rB;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var y = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        
        transform.Rotate(0, y*Rotate_speed, 0);
        transform.Translate(0, 0, z);
        
        direction.Normalize();
        //追加
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) 
            || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (audioSource.isPlaying) return;
            audioSource.PlayOneShot(moveSE);
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow)|| 
                 Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (audioSource.isPlaying) return;
            audioSource.PlayOneShot(moveSE);
        }
        else
        {
            audioSource.Stop();
        }

        //Houtou.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            rB.constraints = RigidbodyConstraints.FreezePositionY;
        }

    }
}
