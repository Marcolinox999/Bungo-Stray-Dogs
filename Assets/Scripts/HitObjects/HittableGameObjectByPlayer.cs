using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHittableGameObjectByPlayer
{
    public void HitByPlayer(float damage, CharacterBeatController player)
    {
        Collider2D[] objects = Physics2D.OverlapBoxAll(player.GetComponent<CharacterBeatController>().m_hitAnchor.position, player.GetComponent<CharacterBeatController>().m_hitSize, 0);

        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].GetComponent<IHittableGameObjectByPlayer>() != null)
            {
                objects[i].GetComponent<IHittableGameObjectByPlayer>().HitByPlayer(player.GetComponent<CharacterBeatController>().m_damagePerHit, player);
            }
            
            if (objects[i].gameObject.tag.Equals("Enemy"))
            {

            }
            else if (objects[i].gameObject.tag.Equals("HealthItem"))
            {

            }
            else if (objects[i].gameObject.tag.Equals("InvencibilityItem"))
            {

            }

        }
    }
}
