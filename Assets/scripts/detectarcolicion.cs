using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class detectarcolicion : MonoBehaviour
{
    public Text Puntos;
    public float puntos = 0f;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        puntos++;
        Puntos.text= Puntos.ToString();
    }
}
