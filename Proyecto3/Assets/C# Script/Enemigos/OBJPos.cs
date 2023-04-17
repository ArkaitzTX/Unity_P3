using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaje", menuName = "Objetos/Posiciones", order = 1)]
public class OBJPos : ScriptableObject
{
    public Vector3[] posiciones;
}
