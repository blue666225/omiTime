using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandmineDeath : MonoBehaviour
{
    Vector3 origin1;
    Vector3 directions;
    List<GameObject> deathobjectlist = new List<GameObject>();
    [SerializeField]
    GameObject LandmiinePrefab;
    Vector3 center;
    //public float radius;
    [SerializeField]
    LayerMask layerMask;
    //追加
    AudioSource audioSource;
    public AudioClip bombSE;



    // Start is called before the first frame update
    void Start()
    {
        //var col = GetComponent<SphereCollider>();
        //var hits = Physics.SphereCastAll(col.transform.position, col.radius, transform.forward, 1000, col.gameObject.layer);
        //foreach (var hit in hits)
        //{
        //    Debug.Log("if来たよ");
        //    Destroy(hit.transform.gameObject);
        //}
        var sphereCollider = GetComponent<SphereCollider>();
        var radius2 = sphereCollider.radius * transform.lossyScale.x;

        //追加
        audioSource = GetComponent<AudioSource>();

        ExpDestroy(center, radius2);
    }

    void ExpDestroy(Vector3 center, float radius)
    {

        //音追加
        audioSource.PlayOneShot(bombSE);

        center = transform.position;
        Collider[] hitColliders = Physics.OverlapSphere(center, radius, layerMask);
        int i = 0;

        while (i < hitColliders.Length)
        {
            //hitColliders[i].SendMessage("鈴木");
            Debug.Log(center);
            Destroy(hitColliders[i].gameObject);
            i++;
        }


        //for (int i = 0; i < 10; i++)
        //{
        //    Destroy(hitColliders[i].gameObject);
        //    i++;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        #region Updateゴリラ
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //Destroy(player);
        //GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        //Destroy(enemy);
        //GameObject fragileWall = GameObject.FindGameObjectWithTag("FragileWall");
        //Destroy(fragileWall); 
        #endregion
    }

    //void OnCollisionStay(Collision collision)
    //{
    //if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy")
    //    || collision.gameObject.CompareTag("fragileWall"))
    //{
    //    Debug.Log("if来たよ");
    //    deathobjectlist.Add(collision.gameObject);
    //    //Destroy(collision.gameObject);
    //}

    //foreach (var deathgameObject in collision.contacts)
    //{
    //    Debug.Log("foreach来たよ");
    //}
    //}

    #region   //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Destroy(collision.gameObject);
    //    } 
    //}

    //public void ShooyRay()
    //{
    //    origin1 = transform.position;

    //    RaycastHit hit;

    //    if (Physics.Raycast(origin1,direction,out hit))
    //    {
    //        Debug.DrawLine(transform.position, hit.point, Color.green);
    //    }
    //}

    //static Vector3 pos = new Vector3(0.0f, 10.0f, 0.0f);
    //static Vector3 direction = new Vector3(0.0f, -1.0f, 0.0f);
    //Ray ray = new Ray(pos, direction);
    //RaycastHit[] hit_list;
    //float max_distance = 10.0f;
    #endregion

}
