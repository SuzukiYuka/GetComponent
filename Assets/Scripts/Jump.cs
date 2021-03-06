﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    
    public float power = 500.0f;
    private Rigidbody _rigidbody;

    private void Start() {
        
        _rigidbody = this.GetComponent<Rigidbody>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            
            this._rigidbody.AddForce(Vector3.up * power);
        }
    }
}
