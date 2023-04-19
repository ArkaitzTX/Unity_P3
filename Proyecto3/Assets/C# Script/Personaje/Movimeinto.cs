using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArrayFunc;

public class Movimeinto : MonoBehaviour
{
    Personaje personaje;
    GameObject[] enemigos;
    bool recargado = true;

    private void Start()
    {
        BuscarEnemigos();
        personaje = GetComponent<Personaje>();
    }

    void Update()
    {
        var axis = (x: Input.GetAxis("Vertical"), 0, z: Input.GetAxis("Horizontal"));

        //Movimiento X Z
        if (new Vector3(axis.x, 0, -axis.z) != Vector3.zero)
        {
            //Rotar el personaje
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(new Vector3(axis.z, 0, axis.x).normalized),
                personaje.CogerPersonaje().velocidadGiro * Time.deltaTime
            );
            //Mover el personaje
            transform.Translate(
                new Vector3(axis.z, 0, axis.x).normalized * Time.deltaTime * personaje.CogerPersonaje().velocidad,
                Space.World
            );
        }
        //Apuntar a los enemigos
        else
        {
            //busca al enemigo
            BuscarEnemigos();
            GameObject enemigo = null;
            float minValor = Mathf.Infinity;

            enemigos.ForEach(e => {
                float valor = Vector3.Distance(transform.position, e.transform.position);

                if (valor < minValor && !Physics.Linecast(transform.position, e.transform.position, LayerMask.GetMask("Obstaculo")))
                {
                    minValor = valor;
                    enemigo = e;
                }

            });

            //rota el personaje
            if (enemigo != null)
            {
                transform.LookAt(enemigo.transform);

                if (recargado) {
                    personaje.arma.Disparo(enemigo);
                    recargado = false;
                    StartCoroutine(Recarga());
                }
            }
        }
    }

    IEnumerator Recarga()
    {
        yield return new WaitForSeconds(personaje.CogerArma().cadencia);
        recargado = true;
    }

    void BuscarEnemigos() {
        enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
    }

}
