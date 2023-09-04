using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPMike : MonoBehaviour
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
        int ranEnemy = Random.Range(0, 4); //��ȭ�� ������Ʈ ����
        int ranPoint = Random.Range(0, 2); //���� ��ġ ���� 5��
        Instantiate(enemyObjs[ranEnemy],
                    spawnPoints[ranPoint].position,
                    spawnPoints[ranPoint].rotation);
    }


}