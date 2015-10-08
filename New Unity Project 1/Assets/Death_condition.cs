using UnityEngine;
using System.Collections;

public class Death_condition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	
	}


    void OnTriggerEnter(Collider other)
    {

        //   if(col.gameObject.name =="Barrier")
        //Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag =="Barrier")
        {

            Debug.Log("Dead");
        }

        
        


    }
}
