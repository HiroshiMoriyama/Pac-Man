using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicCubeManager : MonoBehaviour
{
    public GameObject cubeD;
    public GameObject cubeE;
    public GameObject cubeFsharp;
    public GameObject cubeA;
    public GameObject cubeH;

    public float MinRange;
    public float MaxRangeX;
    public float MaxRangeZ;
    public int cubeNum;

    void Start()
    {
        object[,] cubePos = new object[25, 25];

        cubePos[0, 0] = Instantiate(cubeFsharp);

        for (int i = 1; i <= cubeNum; i++)
        {
            Instantiate(cubeD, new Vector3(Random.Range(MinRange, MaxRangeX), 0.4f,
                Random.Range(MinRange, MaxRangeZ)),
                Quaternion.identity);

            Instantiate(cubeE, new Vector3(Random.Range(MinRange, MaxRangeX), 0.4f,
                Random.Range(MinRange, MaxRangeZ)),
                Quaternion.identity);

            Instantiate(cubeFsharp, new Vector3(Random.Range(MinRange, MaxRangeX), 0.4f,
                Random.Range(MinRange, MaxRangeZ)),
                Quaternion.identity);

            Instantiate(cubeA, new Vector3(Random.Range(MinRange, MaxRangeX), 0.4f,
                Random.Range(MinRange, MaxRangeZ)),
                Quaternion.identity);

            Instantiate(cubeH, new Vector3(Random.Range(MinRange, MaxRangeX), 0.4f,
                Random.Range(MinRange, MaxRangeZ)),
                Quaternion.identity);
        }
    }
}
