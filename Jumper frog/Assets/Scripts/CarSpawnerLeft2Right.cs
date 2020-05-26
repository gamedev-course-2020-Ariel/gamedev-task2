using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnerLeft2Right : MonoBehaviour
{

    [SerializeField] Mover[] prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")] [SerializeField] float minTimeBetweenSpawns = 1.5f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")] [SerializeField] float maxTimeBetweenSpawns = 3.5f;
   
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
        velocityOfSpawnedObject = new Vector3(-3,0,0);
    }

    private IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawns);
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x,
                transform.position.y, transform.position.z);

            int random_prefab = Random.Range(0, prefabToSpawn.Length-1);
            GameObject pre = prefabToSpawn[random_prefab].gameObject;
            GameObject newObject = Instantiate(pre, positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Transform>().Rotate(0, 270, 0);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            bool is_leftToRight = true;
            newObject.GetComponent<Mover>().SetDirection(is_leftToRight);
        }
    }
}
