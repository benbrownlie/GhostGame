using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float MoveForce = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical"))
            _rigidbody.AddForce(new Vector3(0, 0, MoveForce), ForceMode.Force);
        if (Input.GetButtonDown("Horizontal"))
            _rigidbody.AddForce(new Vector3(MoveForce, 0, 0), ForceMode.Force);
    }
}
