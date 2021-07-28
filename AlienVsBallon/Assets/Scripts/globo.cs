using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globo : MonoBehaviour
{

    [SerializeField] Vector3 force;
    
    [SerializeField] Sprite[] ballonSprites;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = ballonSprites[Random.Range(0, 10)];

        transform.position = new Vector3(Random.Range(-3.58f, -9.67f),transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(150, 250), 0);
        rb.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TopWall")
        {
            Destroy(this.gameObject);
        }   
    }

}
