using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smallcircle : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float hiz2;
    public bool cubuk;
    private bool isCompleted;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!GameManager.instance.IsGamePaused && !isCompleted) rb.velocity = Vector2.up * hiz2;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Circle")
        {
            isCompleted = true;
            rb.velocity = Vector2.zero;
            transform.SetParent(collision.transform);
            GameManager.instance.increaseScore();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SmallCircle")
        {
            GameManager.instance.IsGamePaused = true;
            Time.timeScale = 0f;
        }
    }
}
