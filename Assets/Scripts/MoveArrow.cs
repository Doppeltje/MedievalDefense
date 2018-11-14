using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    private int moveSpeed = 10;
    private float speed = 2f;
    private float rotateSpeed = 300f;

    Vector2 target;
    Lock_On _lockOn;
    Rigidbody2D rb;

    private void Start()
    {
        _lockOn = FindObjectOfType<Lock_On>();
        target.x = _lockOn.targetX;
        target.y = _lockOn.targetY;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 2);
	}

    private void FixedUpdate()
    {
        Vector2 direction = target - rb.position;

        direction.Normalize();

        float rotateAmount =  Vector3.Cross(direction, transform.right).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.right * speed;
    }

    void DestroyArrow()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            DestroyArrow();
        }
    }

}
