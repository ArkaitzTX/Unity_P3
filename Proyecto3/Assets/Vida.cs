using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    Personaje personaje;

    private void Start()
    {
        personaje = GetComponent<Personaje>();
    }
}

