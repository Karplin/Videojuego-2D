using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globospawnerazul : MonoBehaviour
{
    [SerializeField] GameObject ballonPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, 7f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Instantiate(ballonPrefab, transform.position, transform.rotation);
    }

}
