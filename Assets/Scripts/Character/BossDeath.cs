using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossDeath : MonoBehaviour
{
    private GameObject boss;

    private void Awake()
    {
        boss = this.gameObject;
    }

    private IEnumerator Bossdeath()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        if(boss.GetComponent<EnemyBeatController>().m_currentLife <= 0)
        {
            StartCoroutine(Bossdeath());
        }
}
}
