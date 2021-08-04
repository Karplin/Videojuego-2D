using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;
    public Vector2 playerDirection;
  
    // Start is called before the first frame update
    void Start()
    {
        TimerController.instance.BeginTimer();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        float direccionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, direccionY).normalized;


        if (Scorescript.scoreValue < 1)
        {
            GameOver();
        }
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }


    public GamerOverScreen GamerOverScreen;
    int max = 0;

    public void GameOver()
    {
        GamerOverScreen.Setup(max);
    }


}

