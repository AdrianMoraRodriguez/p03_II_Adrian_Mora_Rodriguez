using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej11 : MonoBehaviour
{
  void OnTriggerEnter(Collider other) {
    Debug.Log("Collision with " + other.gameObject.tag);
  }
}
