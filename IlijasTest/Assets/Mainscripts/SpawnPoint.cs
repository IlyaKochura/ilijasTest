using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class SpawnPoint : MonoBehaviour
{
    private float _time = 0.7f;
    private int _speed = 1;
    void Update()
    {
        if (_time > 0)
        {
            _time -= Time.deltaTime * _speed;
        }
        else
        {
            transform.position = new Vector3(SpawnPoin().x, SpawnPoin().y);
            _time = 1;
        }
    }
    
    private Vector3 SpawnPoin()
    {
        Random rnd = new Random();
        int random = rnd.Next(-2500, 2500);
        Vector3 newpos = new Vector3(random / 1000, 0);
        return newpos;
    }
}
