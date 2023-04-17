using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    Personaje personaje;
    float vida;
    bool muerto;

    private void Start()
    {
        personaje = GetComponent<Personaje>();
        vida = personaje.CogerPersonaje().vida;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Municion") {
            Municion script = other.gameObject.GetComponent<Municion>();
            if (gameObject.tag != script.miTag)
            {
                vida -= script.daño;
                Destroy(other.gameObject);

                if (vida <= 0 != muerto)
                {
                    muerto = true;
                    Muerte();
                }
            }
        }
    }

    void Muerte() {
        Destroy(gameObject);
    }
}

