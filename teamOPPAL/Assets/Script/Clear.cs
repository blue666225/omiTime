using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    private GameObject[] enemyObj;
    private GameObject[] bossObj;
    public GameObject[] pl;
    public static int sceneNum;
    [SerializeField]
    Scene nextScene;

    // Start is called before the first frame update
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        //Enemyタグをまとめる
        enemyObj = GameObject.FindGameObjectsWithTag("Enemy");
        bossObj = GameObject.FindGameObjectsWithTag("Boss");
        //player生存
        pl = GameObject.FindGameObjectsWithTag("Player");
        //データの入った箱の数をコンソール画面に表示
        //print(enemyObj.Length);
        //print(pl.Length);
        //print(SceneManager.sceneCount);

        //print(SceneManager.GetActiveScene().buildIndex); 
        //0になったらクリア
        Debug.Log("EnemyTag =" + enemyObj.Length);
        if (pl.Length == 0)
        {
            Debug.Log("きたよ");

            FadeManager.Instance.LoadScene("GameOver", 1.0f);
        }
        else if (enemyObj.Length == 0 && bossObj.Length == 0)
        {
            FadeManager.Instance.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, 1.0f);
            //SceneManager.LoadScene("Stage1");
        }
        if (Input.GetButtonDown("Jump"))
        {
            FadeManager.Instance.LoadScene("Title",1.0f);
        }
    }
}
