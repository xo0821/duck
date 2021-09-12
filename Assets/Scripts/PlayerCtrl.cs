using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerCtrl : MonoBehaviour
{

    [SerializeField] LayerMask layerMask;

    Rigidbody2D rigidbody2D;
    Animator animator;
    BoxCollider2D boxCollider;
    public float speed = 10.0f;
    public static bool CanMove = true;
    private bool isPlay;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = transform.GetComponent<Rigidbody2D>();
        animator = transform.GetComponent<Animator>();
        boxCollider = transform.GetComponent<BoxCollider2D>();
        CanMove = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        Jump();
        HandleMovement();
    }

    bool IsGrounded() {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size,0f,Vector2.down,.1f,layerMask);
        return raycastHit2D.collider != null;
    }

    void Jump() {
        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * speed / 2;
        }
    }


    void HandleMovement() {
        if ((Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))&&CanMove)
        {
            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
            animator.SetBool("IsMove", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else {
            if ((Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) && CanMove)
            {
                rigidbody2D.velocity = new Vector2(-speed, rigidbody2D.velocity.y);
                animator.SetBool("IsMove", true);
                transform.localScale = new Vector3(1,1,1);
            }
            else {
                rigidbody2D.velocity = new Vector2(0,rigidbody2D.velocity.y);
                animator.SetBool("IsMove",false);
            }
        }
    }
}
