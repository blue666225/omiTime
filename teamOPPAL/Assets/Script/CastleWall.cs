using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleWall : MonoBehaviour
{
    public int wallHp;
    public GameObject bossEnemy;
    public GameObject CastlePrefab;
    public static int CCount = 1;

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
            wallHp -= 1;
            if (wallHp == 0)
            {
                CCount -= 1;
                //Instantiate(bossEnemy, new Vector3(0, 2, 88), transform.rotation);
                Destroy(CastlePrefab);

            }
        }
    }

}
