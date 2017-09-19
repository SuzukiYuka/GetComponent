using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = this.GetComponent<Renderer>();
    }
    // Use this for initialization
    void Start()
    {
        changeColor();
    }

    public Color GetColor()
    {
        return _renderer.material.color;
    }

    public void changeColor()
    {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
    }
}
