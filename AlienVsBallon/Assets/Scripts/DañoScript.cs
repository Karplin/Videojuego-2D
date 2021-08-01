using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoScript : MonoBehaviour
{
    public int vida = 1;

    public GameObject desaparecer;

    public void recibirDaño(int daño)
    {
        vida -= daño;

        if(vida <= 0)
        {
            Muere();
        }

        void Muere()
        {
            Scorescript.scoreValue += 1;
            Instantiate(desaparecer, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}