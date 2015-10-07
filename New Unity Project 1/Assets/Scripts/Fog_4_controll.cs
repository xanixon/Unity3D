using UnityEngine;
using System.Collections;

public class Fog_4_controll : MonoBehaviour {

    public SpriteRenderer _sprite = null;
    // Use this for initialization
    void Start()
    {
        var color = _sprite.color;
        color.a = 0.2f;
        _sprite.color = color;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
