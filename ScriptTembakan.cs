using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTembakan : MonoBehaviour
{
    public Rigidbody2D rb;
    public CapsuleCollider2D c2d;
    public float kecepatan = 20f;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // LANGSUNG CEPAT KE ATAS
        rb.velocity = Vector2.up * kecepatan;
    }

    void Update()
    {
        
    }
}
