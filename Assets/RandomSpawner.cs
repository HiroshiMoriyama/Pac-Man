using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject respawnPrefab;    //オブジェクト格納
    private GameObject[] spawnPoints;   //生成位置格納
    public static Vector3 spawnPoint;   //生成位置格納
    public static Vector3 RespawnPoint; //前回の生成位置格納
    public static Vector3 prefabPoint;

    public int cubeNum;


    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Respawn");

        for (int i = 1; i <= cubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Length > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;
                    // インデントを代入
                    // タグ名を変更
                    // 座標を代入
                }
                // ifでタグ名が変更された場合Instantiate
                Instantiate(respawnPrefab, spawnPoint, Quaternion.identity);
                RespawnPoint = spawnPoint;
                prefabPoint = respawnPrefab.transform.position;
            }
        }
    }
}
