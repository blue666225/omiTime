using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float MoveSpeed;
    public float rotationSmooth;
    public Vector3 GoalPos;
    private float changeTargetDistance = 40.0f;
    float seconds;

    // Start is called before the first frame update
    void Start()
    {
        GoalPos = GetRandomPositionOnlevel();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;

        AIMove();
        
    }

    public void AIMove()
    {
        //目標地点（GoalPos）との距離（distanceToTarget）が、指定の数（changeTargetDistance）
        //よりも小さくなっていたら新しい目標地点を設定する
        float distanceToTarget = Vector3.SqrMagnitude(transform.position - GoalPos);
        if (distanceToTarget < changeTargetDistance || seconds >= 3)
        {
            seconds = 0;
            GoalPos = GetRandomPositionOnlevel();
        }


        Quaternion targetRotation = Quaternion.LookRotation(GoalPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime
             * rotationSmooth);

        //前進
        transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
    }

    public Vector3 GetRandomPositionOnlevel()
    {
        float Level = 55f;
        return new
             Vector3(Random.Range(-Level, Level), 0, Random.Range(-Level, Level));
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("Player")
            || collision.gameObject.CompareTag("Enemy"))
        {
             GoalPos = GetRandomPositionOnlevel();
        }
    }
}
