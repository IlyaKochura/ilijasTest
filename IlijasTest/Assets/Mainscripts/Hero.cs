using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var axis = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(axis * speed * Time.deltaTime, 0);
        transform.Translate(direction);
        MovingEdgesScene();
    }
    
    private void MovingEdgesScene()
    {

        if (transform.position.x < -2.5f)
        {
            transform.position = new Vector3(2.5f, transform.position.y, 0);
        }
            
        if (transform.position.x > 2.5f)
        {
            transform.position = new Vector3(-2.5f, transform.position.y, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
        }
    }
}

