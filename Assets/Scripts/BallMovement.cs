using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private bool isOnSlider = true;

    private Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetAxis("Push") != 0 && isOnSlider)
        {
            isOnSlider = false;
            transform.SetParent(null);
            body.AddForce(transform.forward * speed);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        body.velocity = Vector3.zero;

        var heading = other.contacts[0].point - transform.position;
        var distance = heading.magnitude;
        var direction = Vector3.Reflect(heading / distance, other.contacts[0].normal) - new Vector3(0.01f, 0, 0.01f);

        body.AddForce(direction * speed);
        //transform.Rotate(new Vector3(0, 90, 0));
        
    }
}
