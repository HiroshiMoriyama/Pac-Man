using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCubeSpawner : MonoBehaviour
{
    public GameObject musicCubeD;    //オブジェクト格納
    public GameObject musicCubeE;
    public GameObject musicCubeFsharp;
    public GameObject musicCubeA;
    public GameObject musicCubeH;

    private List<GameObject> spawnPoints;   //生成位置格納
    public static Vector3 spawnPoint;   //生成位置格納
    public static Vector3 RespawnPoint; //前回の生成位置格納

    public int cubeNum;     // Cube生成数(オブジェクトの数×cubeNum)
    public int UpperMiddleCubeNum;
    public int MiddleCubeNum;
    public int LowerMiddleCubeNum;


    void Start()
    {
        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPointUpper"));

        for (int i = 1; i <= cubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPointBottom"));

        for (int i = 1; i <= cubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPointLeft"));

        for (int i = 1; i <= cubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPointRight"));

        for (int i = 1; i <= cubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPoint UpperMiddle"));

        for (int i = 1; i <= UpperMiddleCubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPoint Middle"));

        for (int i = 1; i <= MiddleCubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }

        spawnPoints = new List<GameObject>(GameObject.FindGameObjectsWithTag("SPoint LowerMiddle"));

        for (int i = 1; i <= LowerMiddleCubeNum; i++)
        {
            if (spawnPoints != null && spawnPoints.Count > 0)
            {
                while (spawnPoint == RespawnPoint)
                {
                    int index = Random.Range(0, spawnPoints.Count);     // インデックス番号を取得
                    spawnPoint = spawnPoints[index].transform.position;     // ランダムで選出された要素の座標を取得
                    Instantiate(musicCubeD, spawnPoint, Quaternion.identity);    // Cubeをインスタンス
                    spawnPoints.RemoveAt(index);    // ランダム選出されたインデックスの削除

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeE, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeFsharp, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeA, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);

                    index = Random.Range(0, spawnPoints.Count);
                    spawnPoint = spawnPoints[index].transform.position;
                    Instantiate(musicCubeH, spawnPoint, Quaternion.identity);
                    spawnPoints.RemoveAt(index);
                }
                RespawnPoint = spawnPoint;
            }
        }
    }
}
