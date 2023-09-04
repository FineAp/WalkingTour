using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPBike : MonoBehaviour
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
            maxSpawnDelay = Random.Range(0.5f, 1f); //���� ī��Ʈ
            curSpawnDelay = 0;
        }

    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(0, 2); //��ȭ�� ������Ʈ ����
        int ranPoint = Random.Range(0, 14); //���� ��ġ ���� 5��
        Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }


}