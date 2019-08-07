using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject respawnPrefab;    //オブジェクト格納
    private GameObject[] spawnPoints;   //生成位置格納
    public static Vector3 spawnPoint;   //生成位置格納
    public static Vector3 RespawnPoint; //前回の生成位置格納


    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");

        if (spawnPoints != null && spawnPoints.Length > 0)
        {
            while (spawnPoint == RespawnPoint)
            {
                spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
            }

            Instantiate(respawnPrefab, spawnPoint, transform.rotation);
            RespawnPoint = spawnPoint;
        }
    }
}
