using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject MusicCube;
    int MCCount;

    void Start()
    {
        MusicCube = GameObject.Find("MusicCubes");
    }
    
    void Update()
    {
        if (MCCount <= 0)
        {

        }
    }
}
