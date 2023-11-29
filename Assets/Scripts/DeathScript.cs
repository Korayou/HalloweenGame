using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject[] weapons;
    Animator m_Animator;
    public Animator skeletonAnimator;
    public AudioSource deathAudio;
    float _DieDuration;
    private bool _hasPlayedDeathAudio = false;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        AnimationClip[] clips = m_Animator.runtimeAnimatorController.animationClips;
        foreach (AnimationClip clip in clips)
        {
            if (clip != null && clip.name == "Damage_02")
            {
                _DieDuration = clip.length;
                break;
            }
        }
        GameManager.Instance.addMob();
    }

    void OnTriggerEnter(Collider other)
    {
        if (skeletonAnimator.GetComponent<Attack>().IsInAttackingAnimationState)
        {
            for (int i = 0; i < weapons?.Length; i++)
            {
                if (weapons[i] != null && weapons[i] == other.gameObject)
                {
                    m_Animator.SetBool("isDying", true);
                    if (!_hasPlayedDeathAudio)
                    {
                        deathAudio.Play();
                        _hasPlayedDeathAudio = true;
                    }
                    StartCoroutine(Die());
                    break;
                }
            }
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(_DieDuration);
        Destroy(gameObject);
        GameManager.Instance.removeMob();
    }
}
