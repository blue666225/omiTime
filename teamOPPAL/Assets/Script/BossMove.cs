using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMove : MonoBehaviour
{
    //public Transform target = null;
    //public float MoveSpeed;
    //public float speed;
    //public float attenuation;
    //public Transform target;
    public GameObject target;
    private NavMeshAgent nav;
    private GameObject[] ptag;
    //private Vector3 velocity;
    //public GameObject CPre;

    // Start is called before the first frame update
    void Start()
    {
        //NavMeshAgent agent = GetComponent<NavMeshAgent>();
        nav = GetComponent<NavMeshAgent>();



    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        //transform.Translate((-Vector3.forward)* MoveSpeed * Time.deltaTime);
        //velocity += (target.position - transform.position) * speed;
        //velocity *= attenuation;
        //transform.position += velocity *= Time.deltaTime;

        //nav.SetDestination(target.position);
        ptag = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log("ptagの長さ = " + ptag.Length);

        if (ptag.Length != 0)
        {
            if (CastleWall.CCount == 0)
            {

                nav.destination = target.transform.position;
            }
        }   
    }
}
