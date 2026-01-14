using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpforce_ = 5f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameController _controller;
    [SerializeField] private Rigidbody2D rb_;
    [SerializeField] private bool isGrounded;
    // Start is called before the first frame update
    private void Start()
    {
        rb_ = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb_.velocity = new Vector2(rb_.velocity.x, jumpforce_);
        isGrounded = false;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("Ground"))
        { isGrounded = true; }
    }

}
    
