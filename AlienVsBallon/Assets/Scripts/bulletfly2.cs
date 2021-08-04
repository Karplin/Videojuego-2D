using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly2 : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 20f;
    public Rigidbody2D rb;
    public int daño = 2;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        danoazul enemigo = hit.GetComponent<danoazul>();

        if (enemigo != null)
        {
            enemigo.recibirDaño(daño);
        }

        Destroy(gameObject);
    }

}
