using UnityEngine;
using System.Collections;

public class Respawner : MonoBehaviour {

    public GameObject barrierPrefab;

    private int offset;
    public float LastSpawn;
    private Transform thisTransform;
    private GameObject barrier;
	// Use this for initialization
	void Start () {




        thisTransform = transform;
        LastSpawn = Time.time;

        barrier = GameObject.Find("Barrier");
        offset = 250/barrier.GetComponent<Barrier_Controll>().Get_speed();
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time > offset+LastSpawn)
        {
           // Debug.Log("TimeToSpawn");
            for (int i = 0; i < 10; i++)
            {
                Instantiate(barrierPrefab, new Vector3(thisTransform.position.x,          //от иксовой координаты спаунера
                                                       0,                                  //на уровне пола
                                                       thisTransform.position.z-200*i)     //с шагом 150м, дабы не сливались
                    , thisTransform.rotation);
            }
            LastSpawn = Time.time;
        }
	
	}
}
