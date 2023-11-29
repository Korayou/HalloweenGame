using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Animator m_Animator;
    public bool IsInAttackingAnimationState { get; set; }
    public AudioSource hitAudio;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space)) && !IsInAttackingAnimationState)
        {
            m_Animator.SetTrigger("IsAttacking");
            hitAudio.Play();
        }
    }
}
