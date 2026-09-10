using UnityEngine;

public class StarVelocity : MonoBehaviour
{
    public Vector3 velocity;
    public float gravity = 1.4f;
    public Transform planet;

    public void Launch(Vector3 aimDir)
    {
        Vector3 r = transform.position - planet.position; 
        float distance = r.magnitude;
        Vector3 rHat = r / distance;

        Vector3 tangential = aimDir - r;

        if (tangential.magnitude < 1e-4f)
            tangential = Vector3.Cross(rHat, Vector3.up);

        float speed = Mathf.Sqrt(gravity / distance);
        velocity = tangential.normalized * speed;
    }

    void Start()
    {

    }

    void Update()
    {
        Vector3 r = transform.position - planet.position;
        float distance = r.magnitude;
        Vector3 acceleration = -gravity * r / (distance * distance * distance);

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
    }
}