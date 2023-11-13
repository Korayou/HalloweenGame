using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Attack : MonoBehaviour
{
    Animator m_Animator;
    public bool IsInAttackingAnimationState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButton(0) || Input.GetKeyDown(KeyCode.Space)) && !IsInAttackingAnimationState)
        {
            m_Animator.SetTrigger("IsAttacking");
        }

        /*if (Input.GetMouseButton(0))
        {
            m_Direction.Set(Input.mousePosition.x, 0f, Input.mousePosition.z);
            m_Direction.Normalize();
            Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Direction, turnSpeed * Time.deltaTime, 0f);
            m_Rotation = Quaternion.LookRotation(desiredForward);
            m_Rigidbody.MoveRotation(m_Rotation);
        }*/
    }
}
