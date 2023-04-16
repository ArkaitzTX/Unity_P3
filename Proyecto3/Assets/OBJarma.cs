using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Arma", menuName = "Objetos/Arma", order = 1)]
public class OBJarma : ScriptableObject
{
    [SerializeField] [Range(0.1f, 1f)] public float cadencia = .1f;
    [SerializeField] [Range(1f, 100f)] public float daño = 1f;
}
