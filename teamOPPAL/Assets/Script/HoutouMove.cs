using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoutouMove : MonoBehaviour
{
    public float rotateSpeed = 0;
    public float rotationSmooth = 1;
    private Transform Player;
    private GameObject[] ptag;
    public Transform After;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        ptag = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log("ptagの長さ = " + ptag.Length);

        if (ptag.Length == 0)
        {
            //Quaternion targetRotation = Quaternion.LookRotation(After.position - transform.position);
        }
        else if (ptag.Length != 0)

        {
            Debug.Log("TargetPlayerしてるよ");
            TargetPlayer();
        }
    }

    void TargetPlayer()
    {
        Quaternion targetRotation = Quaternion.LookRotation(Player.position - transform.position);
        //Debug.Log("PlayerPosition = " + Player.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime
             * rotationSmooth);
    }

}
