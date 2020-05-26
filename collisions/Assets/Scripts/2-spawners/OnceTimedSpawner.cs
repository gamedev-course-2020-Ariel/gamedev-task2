using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnceTimedSpawner : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float maxTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
            float timeBetweenSpawns = Random.Range(0, maxTimeToSpawn);
            yield return new WaitForSeconds(timeBetweenSpawns);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            Debug.Log("instanciate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
