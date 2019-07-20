using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoutou : MonoBehaviour
{
    Plane plane = new Plane();//3D空間での2Dの表現
    float distance = 0;
    //float RayLength = 100;
    int Quad;
    Rigidbody rH;
    #region Ray
    //float HotoRotX;
    //RaycastHit distance;
    #endregion
    //public GameObject Body;


    // Start is called before the first frame update
    void Start()
    {
        plane.SetNormalAndPosition(Vector3.back, transform.localPosition);
        #region Ray     
        //Quad = LayerMask.GetMask("Ground");
        #endregion
        //rH = Body.GetComponent<Rigidbody>();
        //rH = GetComponent<Rigidbody>();
        //Body = transform.root.gameObject;

    }

    // Update is called once per frame
    void Update()
    {

        Turn();
    }

    void Turn()
    {

        //Debug.Log(Input.mousePosition);
       

        //カメラとマウスの位置をもとにRayを用意
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //プレイヤーの高さにPlaneを更新して、カメラの情報をもとに
        //地面の判定をして距離を取得
        plane.SetNormalAndPosition(Vector3.up, transform.localPosition);

        //Vector3 targetPos =  Houtou.transform.position;
        //targetPos.x = Houtou.transform.position.x;
        //Houtou.transform.LookAt(targetPos);

        if (plane.Raycast(ray, out distance))
        {
            //距離をもとに交差を計算し、交点の方を向く
            var lookPoint = ray.GetPoint(distance);

            transform.LookAt(lookPoint);
        }

        Quaternion a = transform.localRotation;
        a.z = 0;
        a.x = 0;
        transform.localRotation = a;

        #region Ray
        //if (Physics.Raycast(ray, out distance,RayLength,Quad))
        //{
        //    //距離をもとに交差を計算し、交点の方を向く
        //    //var lookPoint = ray.GetPoint(distance);
        //    Vector3 playerToMouse = distance.point - transform.position;
        //    playerToMouse.y = 0f;
        //    Quaternion newRota = Quaternion.LookRotation(playerToMouse);

        //    rH.MoveRotation(newRota);
        //    //transform.LookAt(lookPoint);
        //}
        #endregion

    }


}
