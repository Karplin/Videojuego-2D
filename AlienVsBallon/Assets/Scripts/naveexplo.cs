using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naveexplo : MonoBehaviour
{

    public GameObject explosion;

    public void OnTriggerEnter2D(Collider2D other)
    {
            Debug.Log("hit detected");
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            Destroy(other.gameObject);
            this.gameObject.SetActive(false);
            Destroy(e, 0.5f);
            GameOver();
    }

    public GamerOverScreen GamerOverScreen;
    int max = 0;

    public void GameOver()
    {
        GamerOverScreen.Setup(max);
       
    }


}
