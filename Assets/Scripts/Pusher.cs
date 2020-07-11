using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    [SerializeField] private bool Moving = false;
    [SerializeField] private float PushForce;
    [SerializeField] private float MaxSpeed;
    [Space]
    [SerializeField] private Rigidbody Rigidbody;

    // Update is called once per frame
    void Update()
    {
        if (Moving)
        {
            Rigidbody.AddRelativeForce(Vector3.back * PushForce);

            //Limit the x-axis
            if (Rigidbody.velocity.x > MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.x = MaxSpeed;
                Rigidbody.velocity = velocity;
            }
            else if (Rigidbody.velocity.x < -MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.x = -MaxSpeed;
                Rigidbody.velocity = velocity;
            }

            //Limit the y-axis
            if (Rigidbody.velocity.y > MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.y = MaxSpeed;
                Rigidbody.velocity = velocity;
            }
            else if (Rigidbody.velocity.y < -MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.y = -MaxSpeed;
                Rigidbody.velocity = velocity;
            }

            //Limit the z-axis
            if (Rigidbody.velocity.z > MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.z = MaxSpeed;
                Rigidbody.velocity = velocity;
            }
            else if (Rigidbody.velocity.z < -MaxSpeed)
            {
                Vector3 velocity = Rigidbody.velocity;
                velocity.z = -MaxSpeed;
                Rigidbody.velocity = velocity;
            }
        }
        else
        {
            Vector3 velocity = Rigidbody.velocity;
            velocity = Vector3.zero;
            Rigidbody.velocity = velocity;
        }
    }
}
