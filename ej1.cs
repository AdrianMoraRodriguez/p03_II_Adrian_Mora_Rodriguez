using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej1 : MonoBehaviour
{
    public float velocidad = 3f;
    float horizontal;
      float vertical;
    void Start() {
    }

    // Update is called once per frame
    void Update() {
      horizontal = Input.GetAxis("Horizontal");
      vertical = Input.GetAxis("Vertical");
      if (horizontal != 0) {
        if (horizontal > 0) {
          Debug.Log($"Tecla derecha: Resultado {horizontal * velocidad}");
        } else {
          Debug.Log($"Tecla izquierda: Resultado {horizontal * velocidad}");
        }
      }
      if (vertical != 0) {
        if (vertical > 0) {
          Debug.Log($"Tecla arriba: Resultado {vertical * velocidad}");
        } else {
          Debug.Log($"Tecla abajo: Resultado {vertical * velocidad}");
        }
      }
    }
}
