using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstallation : MonoBehaviour 
{
    public float radius;
    public float pawer;
    public GameObject LandminePrefab;
    float seconds = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 5)
        {
            GameObject landmine = Instantiate(LandminePrefab, transform.position, transform.rotation);
            seconds = 0;
        }
    }

}

