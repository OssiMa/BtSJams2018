using UnityEngine;

public class CirclingEnemyAI : MonoBehaviour
{
    public Vector2 Velocity = new Vector2(1, 0);


    public float RotateSpeed = 1f;

    public float Radius = 1f;

    private Vector2 _centre;
    private float _angle;
    public bool moving;

    public CirclingDirection currentCirclingDirection = CirclingDirection.Clockwise;
    public MovingDirection currentMovingDirection = MovingDirection.Forward;
    private void Start()
    {
        _centre = transform.position;
    }

    private void Update()
    {
        if (moving)
        {
            _centre += Velocity * Time.deltaTime * (int)currentMovingDirection;
        }

        _angle += RotateSpeed * Time.deltaTime * (int)currentCirclingDirection;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;

        transform.position = _centre + offset;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<ThePlayerMovement>().KillPlayer();
        }
        else
        {
            switch(currentCirclingDirection)
            {
                case CirclingDirection.Clockwise:
                    currentCirclingDirection = CirclingDirection.CounterClockwise;
                    break;
                case CirclingDirection.CounterClockwise:
                    currentCirclingDirection = CirclingDirection.Clockwise;
                    break;
            }

        }
    }

    public enum CirclingDirection
    {
        Clockwise = 1,
        CounterClockwise = -1
    }
    public enum MovingDirection
    {
        Forward = 1,
        BackWard = -1
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(_centre, 0.1f);
        Gizmos.DrawLine(_centre, transform.position);
    }
}