using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    // false = right to left , true = left to right
    [Tooltip("Direction of driving")]
    [SerializeField] bool direction;

    float min_x_bound;
    float max_x_bound;
    void Start()
    {
        var camera_pos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
        var size = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize * Screen.width / Screen.height;
        min_x_bound = camera_pos.x - size;
        max_x_bound = camera_pos.x + size;
    }
    void Update()
    {
        if(!direction)
        {
            transform.position += velocity * Time.deltaTime;
            var next_transform = transform.position;
            if (next_transform.x > max_x_bound)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            transform.position += velocity * Time.deltaTime;
            var next_transform = transform.position;
            if (next_transform.x < min_x_bound)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }

    public void SetDirection(bool dir)
    {
        this.direction = dir;
    }
}
