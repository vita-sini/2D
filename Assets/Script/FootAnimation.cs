using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class FootAnimation : MonoBehaviour
{
    private Animator _animator;
    private int _run = Animator.StringToHash("Run");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void AnimationWalking()
    {
        _animator.SetTrigger(_run);
    }
}
