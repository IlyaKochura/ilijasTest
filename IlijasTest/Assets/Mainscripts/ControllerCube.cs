using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class ControllerCube : MonoBehaviour
{
    public GameObject cubePrefab;
    private Vector3 _spawnpoint;
    private List<GameObject> _objects = new();
    
    
    void Start()
    {
        Random rnd = new Random();
        _spawnpoint = new Vector3(0, 6);
        for (int i = 0; i < 3; i++)
        {
            float random = rnd.Next(10, 20);
            var slot = Instantiate(cubePrefab, _spawnpoint, Quaternion.identity);
            _objects.Add(slot);
            _objects[i].GetComponent<CubeScript>().speed = random;
        }
    }
    
    void Update()
    {
        for (int i = 0; i < _objects.Count; i++)
        {
            Random rnd = new Random();
            float random = rnd.Next(-25, 25);
            if (_objects[i].transform.position.y < -6)
            {
                _objects[i].transform.position = new Vector3(random / 10, 6);
            }
        }    
    }
    
    
}
