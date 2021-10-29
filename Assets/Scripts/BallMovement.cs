using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private bool isOnSlider = true;
    [SerializeField] private Vector3 velocity = Vector3.zero;

    private Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //body.velocity = velocity;
        if (Input.GetAxis("Push") != 0 && isOnSlider)
        {
            velocity = transform.forward * speed;
            isOnSlider = false;
            transform.SetParent(null);
            body.AddForce(velocity);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Sasha"))
        {
            body.velocity = velocity;
        }
        //body.velocity = Vector3.zero;

        //var heading = other.contacts[0].point - transform.position;
        //var distance = heading.magnitude;
        //var direction = Vector3.Reflect(heading / distance, other.contacts[0].normal) - new Vector3(0.01f, 0, 0.01f);

        //body.AddForce(direction * speed);
        //transform.Rotate(new Vector3(0, 90, 0));
        //
        //if (other)
        //body.velocity = velocity;
    }
}
