using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej9 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
      Debug.Log("Collision with " + other.gameObject.tag);
    }
}
