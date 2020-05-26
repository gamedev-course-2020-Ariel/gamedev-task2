using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class TimeThePlayer : MonoBehaviour
{
    [SerializeField] GameObject enemySpawner;
    [SerializeField] float duration = 5;
    [SerializeField] float timeToDelay = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            var comps = GameObject.FindObjectsOfType<TimedSpawnerRandom>();
            for (int i = 0; i< comps.Length; i++)
            {
                comps[i].GetComponent<TimedSpawnerRandom>().StartCoroutine(SlowDownEnemies(comps[i]));
            }
            Destroy(gameObject);  // Destroy the shield itself - prevent double-use
        }
    }

    private IEnumerator SlowDownEnemies(TimedSpawnerRandom tsr)
    {
        float prev = tsr.GetaxTimeBetweenSpawns();
        for (float i = duration; i > 0; i--)
        {
            Debug.Log(i + " seconds remaining!");
            tsr.SetmaxTimeBetweenSpawns(timeToDelay);
            yield return new WaitForSeconds(1);
        }
        Debug.Log("gone!");
        tsr.SetmaxTimeBetweenSpawns(prev);
    }
}
