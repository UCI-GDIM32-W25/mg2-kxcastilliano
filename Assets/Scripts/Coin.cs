using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Coin : MonoBehaviour
{
    
    public Collider2D Collider;
    public float moveSpeed = 3f;
    private float Destroyposition = -3f;
   
    // Start is called before the first frame update
    void Start()
    {
       Collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += UnityEngine.Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < Destroyposition) { Destroy(gameObject); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { if (collision.CompareTag("Player"))
        {
            GameController.
            Destroy(gameObject);

            GameController.instance.UpdateScore();

        }
        
    }
}

