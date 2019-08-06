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
    public float MaxRange;
    public int cubeNum;

    void Start()
    {
        for (int i = 1; i <= cubeNum; i++)
        {
            Instantiate(cubeD, new Vector3(Random.Range(MinRange, MaxRange), 0.4f,
                Random.Range(MinRange, MaxRange)),
                Quaternion.identity);

            Instantiate(cubeE, new Vector3(Random.Range(MinRange, MaxRange), 0.4f,
                Random.Range(MinRange, MaxRange)),
                Quaternion.identity);

            Instantiate(cubeFsharp, new Vector3(Random.Range(MinRange, MaxRange), 0.4f,
                Random.Range(MinRange, MaxRange)),
                Quaternion.identity);

            Instantiate(cubeA, new Vector3(Random.Range(MinRange, MaxRange), 0.4f,
                Random.Range(MinRange, MaxRange)),
                Quaternion.identity);

            Instantiate(cubeH, new Vector3(Random.Range(MinRange, MaxRange), 0.4f,
                Random.Range(MinRange, MaxRange)),
                Quaternion.identity);
        }
    }
}
