using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int BossHp;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerTama"))
        {
            BossHp -= 1;
            if(BossHp == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
