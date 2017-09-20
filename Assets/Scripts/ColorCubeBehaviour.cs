using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeBehaviour : MonoBehaviour {
    
    private Renderer cubyRenderer;
    private RandomColor randomColor;

    private void Awake() {

        randomColor = this.GetComponent<RandomColor>();
    }

    private void OnCollisionEnter(Collision collision) {

        cubyRenderer = collision.gameObject.GetComponent<Renderer>();
        cubyRenderer.material.color = randomColor.GetColor();
        randomColor.changeColor();
    }
}
