using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Installation : MonoBehaviour
{
    public float radius;
    public float pawer;
    public GameObject LandminePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Bomb"))
        {
            GameObject landmine = Instantiate(LandminePrefab, transform.position, transform.rotation);
        }
    }

}

