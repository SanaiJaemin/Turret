using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float ActionSpeed = 2f;
    PlayerInput _input;
    Rigidbody _rigidbody;
 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = _input.X * ActionSpeed;
        float zSpeed = _input.Z * ActionSpeed;
        _rigidbody.velocity = new Vector3(xSpeed, 0f, zSpeed);
    }
}
