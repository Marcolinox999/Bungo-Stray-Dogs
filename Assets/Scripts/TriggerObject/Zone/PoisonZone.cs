using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PoisonZone : MonoBehaviour
{
    private GameObject m_player;
    public int damage;
    private bool isPoison = true;

    private void Awake()
    {
        m_player = GameObject.FindGameObjectWithTag("Player");
        m_player.GetComponent<SpriteRenderer>().color = Color.white;
    }
    public IEnumerator Poison(int poisonTimes, float poisonDelay)
    {
        if (isPoison)
        {
            m_player.GetComponent<SpriteRenderer>().color = Color.gray;
            Debug.Log("Poison damage");
            isPoison = false;
            for (int i = 0; i < poisonTimes; i++)
            {
                yield return new WaitForSeconds(poisonDelay);
                m_player.GetComponent<CharacterBeatController>().AddHealth(damage);
            }
            isPoison = true;
            m_player.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    public void PoisonDamage(int times, float delay)
    {
        StartCoroutine(Poison(times, delay));
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.GetComponent<PlayerBeatController>() != null)
        {
            PoisonDamage(2,2f);
        }
    }
}
