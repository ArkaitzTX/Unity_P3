using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] OBJpersonaje[] personajes;
    [SerializeField] int miPersonaje;

    [SerializeField] OBJarma[] armas;
    [SerializeField] int miArma;

    [SerializeField] public Arma arma;

    public OBJarma CogerArma() => armas[miArma];
    public OBJpersonaje CogerPersonaje() => personajes[miPersonaje];
}
