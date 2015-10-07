using UnityEngine;
using System.Collections;

public class Fog_1_Awake : MonoBehaviour {


    public SpriteRenderer _sprite= null;

	// Use this for initialization
	void Start () {
        if(_sprite!= null)
        {
            var color = _sprite.color;
            color.a = 1;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        var color = _sprite.color;
        if(color.a>0)            
        {
            //Debug.Log("a>0");
            color.a -= 0.1f*Random.Range(-1.0f,1.0f);
        }
        else
        {
          //  Debug.Log("achtung");
           color.a = 0.1f;
        }

        _sprite.color = color;
        
	
	}
}
