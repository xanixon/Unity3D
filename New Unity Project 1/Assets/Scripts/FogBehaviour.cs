using UnityEngine;
using System.Collections;

public class FogBehaviour : MonoBehaviour {

    public float Transparency;
    SpriteRenderer _sprite = null;
    // Use this for initialization
    void Start () {

        Color color;
        _sprite = this.GetComponent<SpriteRenderer>();
        color = _sprite.color;
        color.a = Transparency / 100;
        _sprite.color = color;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
