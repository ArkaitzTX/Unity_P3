using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Municion : MonoBehaviour
{
    [SerializeField] [Range(0f, 1000f)] float velocidad;
    [HideInInspector] public Vector3 enemigo, direccion;
    [HideInInspector] public float daño = 0;
    [HideInInspector] public string miTag;

    private void Start()
    {
        direccion = (enemigo - transform.position).normalized;
    }

    void Update()
    {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }
}
