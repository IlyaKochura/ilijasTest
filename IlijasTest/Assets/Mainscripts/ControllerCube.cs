using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class ControllerCube : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnpoint;
    private int _speed = 1;
    private float _time = 1;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (_time > 0)
        {
            _time -= Time.deltaTime * _speed;
        }
        else
        {
            Instantiate(cubePrefab, spawnpoint);
            _time = 1;
        }
    }
    
    
}
