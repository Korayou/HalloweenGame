using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    BoxCollider boxCollider;
    bool m_IsPlayerAtExit;
    float m_Timer;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }

    void Update()
    {
        if (GameManager.Instance.mobsToKill == 0 )
        {
            boxCollider.isTrigger = true;
        }
        if (m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}