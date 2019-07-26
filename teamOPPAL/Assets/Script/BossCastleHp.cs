using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossCastleHp : MonoBehaviour
{
    public GameObject CastlePrefab;
    Slider hpSlider;
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

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerTama"))
        {
            hpSlider.value -= 10f;
            if (hpSlider.value <= 0)
            {
                Destroy(CastlePrefab);
                Destroy(this.hpSlider);               
            }
        }
    }

}