using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnerAttack : MonoBehaviour
{
    [SerializeField] GameObject m_projectile;
    [SerializeField] GameObject[] m_spawn;
    [SerializeField] private float spawnTime;
    private Random m_spawnPointRandom;
    private bool m_spawned = false;
    private IEnumerator SpawnProjectile()
    {
        if (m_spawned == false)
        {
            m_spawned = true;
            yield return new WaitForSeconds(spawnTime);
            int selectedPointRandom = UnityEngine.Random.Range(0, m_spawn.Length);
            Instantiate(m_projectile, m_spawn[selectedPointRandom].transform.position, Quaternion.identity);
            m_spawned = false;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(SpawnProjectile());
    }
}
