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
    }
}
