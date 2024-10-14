using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej10 : MonoBehaviour
{
  void OnCollisionEnter(Collision other) {
    Debug.Log("Collision with " + other.gameObject.tag);
  }
}
