using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform proyectile;
    public GameObject BulletPrefb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {

            Instantiate(BulletPrefb, proyectile.position, proyectile.rotation);
        }
    }
}