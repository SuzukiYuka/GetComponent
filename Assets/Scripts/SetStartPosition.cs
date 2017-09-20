using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartPosition : MonoBehaviour {

    private void Start() {
        
        transform.position = new Vector3(0f, 2f, 0f);
    }
}
