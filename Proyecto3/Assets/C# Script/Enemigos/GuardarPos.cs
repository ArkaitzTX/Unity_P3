using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class GuardarPos : MonoBehaviour
{
    [SerializeField] List<Vector3> posiciones = new List<Vector3>();
    [SerializeField] string nombre;

    [ContextMenu("Añadir")]
    public void Añadir()
    {
        posiciones.Add(transform.position);
    }

    [ContextMenu("Guardar")]
    public void Guardar()
    {
        OBJPos so = ScriptableObject.CreateInstance<OBJPos>();
        so.posiciones = posiciones.ToArray();
        AssetDatabase.CreateAsset(so, $"Assets/Objetos/Movimiento/Movimiento {nombre}.asset");
    }
}
