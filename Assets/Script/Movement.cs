using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FootAnimation))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private FootAnimation _animation;

    private void Awake()
    {
        _animation = GetComponent<FootAnimation>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        int jumpForce = 5;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animation.AnimationWalking();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animation.AnimationWalking();
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, _speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, _speed * Time.deltaTime * -1, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, _speed * Time.deltaTime * jumpForce, 0);
        }
    }
}
