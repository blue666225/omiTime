using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossWallHp : MonoBehaviour
{
    public GameObject CastlePrefab;
    public Slider hpSlider;
    public Slider Bossslider;

    // Use this for initialization
    void Start()
    {

        hpSlider = GetComponent<Slider>();

        float maxHp = 200f;
        float nowHp = 200f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


    }

    // Update is called once per frame
    void Update()
    {
        //// クリックしたときにhpを10減らす。
        //if (Input.GetMouseButtonDown(0))
        //{
        //    hpSlider.value -= 40f;
        //}
    }

    //public void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("PlayerTama"))
    //    {
    //        hpSlider.value -= 40f;
    //        if (hpSlider.value <= 0)
    //        {
    //            Destroy(CastlePrefab);
    //            Destroy(this.hpSlider);
    //            Instantiate(Bossslider, transform.position, transform.rotation);
    //        }
    //    }
    //}

}