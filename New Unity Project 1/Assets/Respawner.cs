using UnityEngine;
using System.Collections;

public class Respawner : MonoBehaviour {

    public GameObject barrierPrefab;

    private int offset = 100;
    private float LastSpawn;
    private Transform thisTransform;
	// Use this for initialization
	void Start () {
        thisTransform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {


        if (Time.time >offset +  LastSpawn)
        {
            Instantiate(barrierPrefab,new Vector3(thisTransform.position.x,thisTransform.position.y,thisTransform.position.z),thisTransform.rotation );
        }
	
	}
}
