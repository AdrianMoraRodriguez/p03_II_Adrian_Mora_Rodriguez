using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej7 : MonoBehaviour
{
    public float speed = 2f;
    public float cubeSpeed = 1f;
    GameObject sphere;
    GameObject cube;

    void Start() {
        sphere = GameObject.Find("Sphere");
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update() {
        if (Mathf.Abs(cube.transform.position.x - sphere.transform.position.x) > 0.1 || Mathf.Abs(cube.transform.position.z - sphere.transform.position.z) > 0.1) {
          cube.transform.LookAt(sphere.transform);
          cube.transform.Translate(Vector3.forward * cubeSpeed * Time.deltaTime, Space.Self);
        }
        float moveH = Input.GetAxis("HorizontalSphere");
        float moveV = Input.GetAxis("VerticalSphere");
        if (moveH != 0 || moveV != 0) {
            sphere.GetComponent<Transform>().Translate(moveH * speed * Time.deltaTime, 0, moveV * speed * Time.deltaTime);
        }
    }
}
