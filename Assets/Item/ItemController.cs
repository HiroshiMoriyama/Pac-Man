using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float time;

    void Start()
    {
        
    }

    public IEnumerator loop(float second)
    {
        while (true)
        {
            yield return new WaitForSeconds(second);
            GameObject enemy = GameObject.Find("Enemy Blue");
            Destroy(enemy);
            Debug.Log("IkeIke");
        }
    }
}
