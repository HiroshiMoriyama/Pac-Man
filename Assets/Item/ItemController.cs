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
        GameObject skull = GameObject.Find("Skull");
        GameObject enemy = GameObject.Find("Enemy Blue");

        while (true)
        {
            yield return new WaitForSeconds(second);


            // PCとenemyの座標が==の場合destroyも可能？上手くいかんかった
            Destroy(enemy);
            Debug.Log("IkeIke");


        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
