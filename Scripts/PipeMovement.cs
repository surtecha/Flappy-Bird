using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime * 2;
        
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
