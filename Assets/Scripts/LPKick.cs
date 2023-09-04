using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPKick : MonoBehaviour
{
    public GameObject[] enemyObjs;
    public Transform[] spawnPoints;

    public float maxSpawnDelay;
    public float curSpawnDelay;
    void Update()
    {
        curSpawnDelay += Time.deltaTime;
        if (curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(0.5f, 1f); //랜덤 카운트
            curSpawnDelay = 0;
        }

    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 4); //소화될 오브젝트 숫자
        int ranPoint = Random.Range(0, 6); //랜덤 위치 숫자 5곳
        Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }


}
