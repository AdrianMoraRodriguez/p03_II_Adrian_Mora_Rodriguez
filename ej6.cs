using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej6 : MonoBehaviour
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
        Vector3 direction = sphere.transform.position - cube.transform.position;
        direction.y = 0;
        direction = direction.normalized;
        if (Mathf.Abs(cube.transform.position.x - sphere.transform.position.x) > 0.1 || Mathf.Abs(cube.transform.position.z - sphere.transform.position.z) > 0.1) {
          cube.transform.Translate(direction * cubeSpeed * Time.deltaTime);
        }
        float moveH = Input.GetAxis("HorizontalSphere");
        float moveV = Input.GetAxis("VerticalSphere");
        if (moveH != 0 || moveV != 0) {
            sphere.GetComponent<Transform>().Translate(moveH * speed * Time.deltaTime, 0, moveV * speed * Time.deltaTime);
        }
    }
}
