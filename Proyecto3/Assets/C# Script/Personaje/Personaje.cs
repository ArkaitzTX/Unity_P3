using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Personaje : MonoBehaviour
{
    [SerializeField] OBJpersonaje personajes;
    [SerializeField] OBJarma armas;

    [SerializeField] public Arma arma;

    public OBJarma CogerArma() => armas;
    public OBJpersonaje CogerPersonaje() => personajes;





#if UNITY_EDITOR
    [ContextMenu("Jugador")]
    public void Jugador()
    {
        armas.hideFlags = HideFlags.None;
        arma.hideFlags = HideFlags.None;
    }
    [ContextMenu("Enemigo")]
    public void Enemigo()
    {
        armas.hideFlags = HideFlags.HideInInspector;
        arma.hideFlags = HideFlags.HideInInspector;
    }
#endif


}
