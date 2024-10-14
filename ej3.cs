using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    public float speed = 2f;
    void Start() {
      
    }

    // Update is called once per frame
    void Update() {
      transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
