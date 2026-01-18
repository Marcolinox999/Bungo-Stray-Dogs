using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PoisonZone : MonoBehaviour
{
    [SerializeField] SpriteRenderer m_playerSpriteRenderer;
    [SerializeField] CharacterBeatController m_player;
    public int damage;
    private bool isPoison = true;
    public IEnumerator Poison(int poisonTimes, float poisonDelay)
    {
        if (isPoison)
        {
            m_playerSpriteRenderer.color = Color.gray;
            Debug.Log("Poison damage");
            isPoison = false;
            for (int i = 0; i < poisonTimes; i++)
            {
                yield return new WaitForSeconds(poisonDelay);
                m_player.AddHealth(damage);
            }
            isPoison = true;
            m_playerSpriteRenderer.color = Color.white;
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
