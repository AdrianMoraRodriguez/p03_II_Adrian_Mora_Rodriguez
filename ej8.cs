using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej8 : MonoBehaviour
{
    public float speed = 2f;
    public float cubeSpeed = 1f;
    public float rotationSpeed = 0.1f;
    GameObject sphere;
    GameObject cube;

    void Start() {
        sphere = GameObject.Find("Sphere");
        cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update() {
        if (Mathf.Abs(cube.transform.position.x - sphere.transform.position.x) > 0.1 || Mathf.Abs(cube.transform.position.z - sphere.transform.position.z) > 0.1) {
          float horizontalInput = Input.GetAxis("HorizontalSphere");
          cube.transform.rotation = Quaternion.Slerp(cube.transform.rotation, Quaternion.LookRotation(sphere.transform.position - cube.transform.position), Time.deltaTime * rotationSpeed);
          cube.transform.Translate(cube.transform.forward * cubeSpeed * Time.deltaTime, Space.World);
        }
        float moveH = Input.GetAxis("HorizontalSphere");
        float moveV = Input.GetAxis("VerticalSphere");
        if (moveH != 0 || moveV != 0) {
            sphere.GetComponent<Transform>().Translate(moveH * speed * Time.deltaTime, 0, moveV * speed * Time.deltaTime);
        }
    }
}
