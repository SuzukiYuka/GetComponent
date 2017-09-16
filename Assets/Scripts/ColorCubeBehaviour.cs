using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeBehaviour : MonoBehaviour {
    Renderer cubyRenderer;
    private RandomColor randomColor;

    private void Awake() {

        randomColor = this.GetComponent<RandomColor>();

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision) {

        cubyRenderer = collision.gameObject.GetComponent<Renderer>();
        cubyRenderer.material.color = randomColor.GetColor();
        randomColor.changeColor();
    }
}
