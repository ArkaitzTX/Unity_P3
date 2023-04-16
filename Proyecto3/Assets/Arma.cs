using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] GameObject municionPadre;
    Personaje personaje;

    private void Start()
    {
        personaje = transform.parent.GetComponent<Personaje>();
    }

    public void Disparo(GameObject enemigo) {
        GameObject municion = Instantiate(Resources.Load<GameObject>($"[PREF] municion"), transform.position, Quaternion.identity);

        Municion script = municion.GetComponent<Municion>();
        script.enemigo = enemigo.transform.position;
        script.daño = personaje.CogerArma().daño;

        municion.transform.parent = municionPadre.transform;
        Destroy(municion, 2f);
    }
}
