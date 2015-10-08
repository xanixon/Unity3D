using UnityEngine;
using System.Collections;
using System;

public class Barrier_Controll : MonoBehaviour {

    private int _Speed=100;
    private Transform thisTransform;
	// Use this for initialization
	void Start () {

        thisTransform = transform;
	
	}
	public int Get_speed()
    {

        return _Speed;

    }
    // Update is called once per frame
    void Update() {
        thisTransform.Translate(new Vector3(-1, 0, 0) * _Speed * Time.deltaTime);
        if (thisTransform.position.x < -200 * thisTransform.localScale.x) //если барьер находится далеко за камерой

        {
            // transform.position = new Vector3(1000, transform.position.y, transform.position.y);

            Destroy(gameObject);
        }

        thisTransform.Translate(0, 0, Input.GetAxis("Horizontal"));

        if (thisTransform.position.z > 750)  //бареьр ушел совсем влево от игрока
        {

            Destroy(gameObject);//разрушить сам объект

            //и создать объект справа, чтобы избежать пустых полей.

           // Instantiate()


        }
    }
}
