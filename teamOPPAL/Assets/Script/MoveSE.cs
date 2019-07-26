using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {            
            //音を鳴らす
            audioSource.PlayOneShot(sound1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //音を鳴らす
            audioSource.PlayOneShot(sound1);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //音を鳴らす
            audioSource.Stop();
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //音を鳴らす
            audioSource.Stop();
        }
    }
}
