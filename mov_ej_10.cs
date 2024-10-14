using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_ej_10 : MonoBehaviour
{
    public float speed = 2f;
    public float speedSphere = 2f;
		GameObject sphere;
		GameObject cube;
    void Start() {
			sphere = GameObject.Find("Sphere");
			cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update() {
      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");
			if (h != 0 || v != 0) {
      	cube.GetComponent<Transform>().Translate(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
			}
      float moveH = Input.GetAxis("HorizontalSphere"); 
      float moveV = Input.GetAxis("VerticalSphere");
			if (moveH != 0 || moveV != 0) {
        Vector3 movement = new Vector3(moveH * speedSphere * Time.deltaTime, 0, moveV * speedSphere * Time.deltaTime);
        sphere.GetComponent<Rigidbody>().AddForce(movement);
			}
    }
}
