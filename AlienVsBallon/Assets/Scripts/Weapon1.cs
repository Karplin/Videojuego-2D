using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform proyectile;
    public GameObject BulletPrefb;
    public AudioClip Gun_Sound;
    private AudioSource Player_Sound;

    private void Start()
    {
        Player_Sound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            Player_Sound.PlayOneShot(Gun_Sound, 1.0f);
        }

        void Shoot()
        {

            Instantiate(BulletPrefb, proyectile.position, proyectile.rotation);
        }
    }
}
