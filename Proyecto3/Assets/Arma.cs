using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] [Range(0.1f, 1f)] public float tiempoRecarga = .1f;
    [SerializeField] [Range(1f, 100f)] public float daño = 1f;

    [SerializeField] GameObject municionPadre;

    public void Disparo(GameObject enemigo) {
        GameObject municion = Instantiate(Resources.Load<GameObject>($"[PREF] municion"), transform.position, Quaternion.identity);

        Municion script = municion.GetComponent<Municion>();
        script.enemigo = enemigo.transform.position;
        script.daño = daño;

        municion.transform.parent = municionPadre.transform;
        Destroy(municion, 2f);
    }
}
