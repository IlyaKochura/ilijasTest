using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class ControllerCube : MonoBehaviour
{
    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;
    public float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MoveDown();
    }

    private void MoveDown()
    {
        Vector3 direction = new Vector3( 0, -1 * speed * Time.deltaTime);
        cube.transform.Translate(direction);
        cube1.transform.Translate(direction);
        cube2.transform.Translate(direction);
        MovingEdgesScene();
    }
    
    private void MovingEdgesScene()
    {
        Random rnd = new Random();
        float random = rnd.Next(-2500, 2500);
        float random1 = rnd.Next(-2500, 2500);
        float random2 = rnd.Next(-2500, 2500);
        
        if (cube.transform.position.y < -6)
        {
            cube.transform.position = new Vector3( cube.transform.position.x, 6, 0);
            cube.transform.position = new Vector3(random / 1000, cube.transform.position.y);
        }
        
        if (cube1.transform.position.y < -6)
        {
            cube1.transform.position = new Vector3( cube1.transform.position.x, 6, 0);
        }
        
        if (cube2.transform.position.y < -6)
        {
            cube2.transform.position = new Vector3( cube2.transform.position.x, 6, 0);
        }
        
    }
}
