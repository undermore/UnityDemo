using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    float X;
    float Y;
    float speed = 10.0f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        X = Input.GetAxisRaw("Horizontal");
        Y = Input.GetAxisRaw("Vertical");

        animator.SetBool("isMoving", X != 0 || Y != 0);
        animator.SetFloat("moveX", X);
        animator.SetFloat("moveY", Y);
        
        this.transform.Translate(Vector3.right * X * Time.deltaTime * speed);
        this.transform.Translate(Vector3.up * Y * Time.deltaTime * speed);

    }
}
