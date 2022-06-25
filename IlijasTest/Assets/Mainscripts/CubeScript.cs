using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        Vector3 direction = new Vector3( 0, -1 * speed * Time.deltaTime);
        transform.Translate(direction);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
