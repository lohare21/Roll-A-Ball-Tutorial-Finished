using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public GameObject player;
    public CanvasGroup winText;

    bool m_WinText;
    float m_Timer;

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject == player)
        {
            m_WinText = true;
        }
    }

    void Update ()
    {
        if(m_WinText)
        {
            EndLevel ();
        }
    }

    void EndLevel ()
    {
        {
            Application.Quit ();
        }
    }
}