using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] float speed = 2f;
    Vector2 motionVector;
    public Vector2 lastMotionVector;
    Animator animator;
    public bool moving;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        motionVector = new Vector2(
            horizontal,
            vertical
            );
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        moving = (horizontal != 0 || vertical != 0);
        animator.SetBool("Moving", moving);

        if (moving)
        {
            lastMotionVector = new Vector2(
                horizontal,
                vertical
                ).normalized;

            animator.SetFloat("LastHorizontal", horizontal);
            animator.SetFloat("LastVertical", vertical);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rigidbody2d.velocity = motionVector * speed;
    }
}
