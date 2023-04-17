using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaje", menuName = "Objetos/Personaje", order = 1)]
public class OBJpersonaje : ScriptableObject
{
    [SerializeField] [Range(0f, 10f)] public float velocidad, velocidadGiro;
    [SerializeField] [Range(0f, 100f)] public float vida;
    [SerializeField] [Range(0f, 10f)] public float suerte;
}
