using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody body;
    [SerializeField] private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        var axis = Input.GetAxis("Horizontal");
        if (axis != 0)
        {
            body.velocity = Vector3.zero;
            body.AddForce(Vector3.right * axis * speed);
        }
    }
}
