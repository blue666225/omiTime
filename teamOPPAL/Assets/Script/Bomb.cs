using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject Landmine;
    public GameObject GetParticle;
    public GameObject GetRange;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void Explode()
    {
        var a = Instantiate(GetParticle, transform.position, transform.rotation).GetComponent<ParticleSystem>();

        //a.Play();
        Instantiate(GetRange, transform.position, transform.rotation);        
        Destroy(Landmine);       
    }

}
