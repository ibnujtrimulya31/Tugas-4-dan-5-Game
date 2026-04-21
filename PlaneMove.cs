using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public GameObject laser;
    public Transform tembakan;
    public float kecepatan;
    public int hp;

    void Start()
    {
        
    }

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector3 arah = new Vector3(horizontal, vertical, 0);
        transform.position += arah * kecepatan * Time.deltaTime;

        // TEMBAK
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser, tembakan.position, Quaternion.identity);
        }
    }
}