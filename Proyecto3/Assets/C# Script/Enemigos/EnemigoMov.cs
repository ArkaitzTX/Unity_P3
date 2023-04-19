using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMov : MonoBehaviour
{
    [SerializeField] OBJPos pos;
    [SerializeField] float espera;

    Personaje personaje;
    int i;

    private void Start()
    {
        personaje = GetComponent<Personaje>();
        transform.position = pos.posiciones[i++];

        StartCoroutine(Mover());
    }

    IEnumerator Mover() {
        yield return new WaitForSeconds(espera);

        //calculo
        Vector3 posActual = pos.posiciones[i++];
        Vector3 direccion = (posActual - transform.position).normalized;

        //rotacion
        while (Quaternion.Angle(transform.rotation, Quaternion.LookRotation(direccion)) > 0.01f)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation, 
                Quaternion.LookRotation(direccion), 
                personaje.CogerPersonaje().velocidadGiro * Time.deltaTime
            );
            yield return null;
        }

        //movimiento
        while (Vector3.Distance(posActual, transform.position) > 0.1f)
        {
            transform.Translate(direccion * personaje.CogerPersonaje().velocidad * Time.deltaTime, Space.World);
            yield return null;
        }
        transform.position = posActual;

        //reinicio
        if (i >= pos.posiciones.Length) i = 0;
        StartCoroutine(Mover());
    }


}
