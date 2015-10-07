using UnityEngine;
using System.Collections;

public class Barrier_Controll : MonoBehaviour {

    private int Speed=50;
    private Transform thisTransform;
	// Use this for initialization
	void Start () {

        thisTransform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(-1, 0, 0)*Speed*Time.deltaTime);
        if (transform.position.x < -200*transform.localScale.x)
        {
            transform.position = new Vector3(1000, transform.position.y, transform.position.y);


        }

        transform.Translate(0, 0 , Input.GetAxis("Horizontal"));
        

    }
}
