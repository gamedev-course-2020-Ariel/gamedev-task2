using UnityEngine;

/**
 * This component moves its object in a fixed velocity.
 * NOTE: velocity is defined as speed+direction.
 *       speed is a number; velocity is a vector.
 */
public class Mover: MonoBehaviour {
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    float min_y_bound;
    float max_y_bound;

    void Start()
    {
        var camera_pos = GameObject.Find("Main Camera").GetComponent<Transform>().position;
        var size = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize * Screen.width / Screen.height;
        min_y_bound = camera_pos.y - size;
        max_y_bound = camera_pos.y + size;
    }

    void Update() {
        transform.position += velocity * Time.deltaTime;

        var next_transform = transform.position;
        if (next_transform.y > max_y_bound || next_transform.y < min_y_bound)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetVelocity(Vector3 newVelocity) {
        this.velocity = newVelocity;
    }

}
