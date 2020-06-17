using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnTarget : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    Vector3 spawnValues;
    [SerializeField]
    float elapsedTime;
    [SerializeField]
    float spawnMostWait;
    [SerializeField]
    float spawnLeastWait;
    [SerializeField]
    int maxTargets;
    [SerializeField]
    int targetSpawnLimit;
    float spawnWait;
    int totalTargetsSpawned;
    int floorLevel = 1;



    /// <summary>
    /// Start is called before the first frame update
    /// Initalizes max number of targets
    /// the total number of targets that can be alive at any time
    /// the count of the total number of targets spawned
    /// </summary>
    void Start()
    {
        totalTargetsSpawned = 0;
    }

   
    /// <summary>
    /// Update is called once per frame
    /// Spawns Targets after a small random time
    /// </summary>
    void Update()
    {
        // waits a random number of seconds from a predefined min and max number of seconds
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);

        // sets a time to spawn the next target
        elapsedTime += Time.deltaTime;

        //once the wait time has been reached
        //spawn a target
        if(elapsedTime > spawnWait)
        {
            WaitSpawner();
            elapsedTime = 0;
        }
    }

    /// <summary>
    /// Gets the number current number of targets in the scene
    /// </summary>
    /// <returns> An integer</returns>
    public int GetNumberOfCurrentTargets()
    {
        return GameObject.FindGameObjectsWithTag("Target").Length;
    }

    /// <summary>
    /// Gets the total number of targets that have spawned
    /// </summary>
    /// <returns> An integer </returns>
    int GetTotalTargetsSpawned()
    {
        return totalTargetsSpawned;
    }

    /// <summary>
    /// Checks to see if the max number of targets have been reached
    /// </summary>
    /// <returns>bool, if max targets have been reached</returns>
    public bool IsMaxTargetsReached()
    {
        return GetTotalTargetsSpawned() >= maxTargets;
    }

    /// <summary>
    /// Checks to see if the max number of targets that 
    /// can be alive at any time has been reached
    /// </summary>
    /// <returns>bool, if the limit has been reached</returns>
    bool IsSpawnLimitReached()
    {
        return GetNumberOfCurrentTargets() >= targetSpawnLimit;
    }

    /// <summary>
    /// Spawns a target at a random location within a given range
    /// increments the total number of targets that have been spawned by 1
    /// </summary>
    void WaitSpawner()
    {
        /*
         * If the max number of targets and the
         * max number of targets that can be alive at
         * any one time has not been reached then spawn a target
         */
        if (!IsMaxTargetsReached() && !IsSpawnLimitReached())
        {
            Vector3 spawnPosition = new Vector3(Random.Range(spawnValues.x, -spawnValues.x), Random.Range(floorLevel,spawnValues.y), 
                Random.Range(-spawnValues.z, spawnValues.z));

            Instantiate(target, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            totalTargetsSpawned++;
        }

    }


}
