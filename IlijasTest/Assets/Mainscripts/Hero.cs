using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }


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
        if (transform.position.y > 600)
        {
            transform.position = new Vector3(transform.position.x, -600, 0);
        }

        if (transform.position.y < -600)
        {
            transform.position = new Vector3(transform.position.x, 600, 0);
        }

        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y, 0);
        }
            
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y, 0);
        }
    }
}
