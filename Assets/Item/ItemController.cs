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

        Vector3 skullPos = skull.transform.position;
        Vector3 enemyPos = enemy.transform.position;

        while (true)
        {
            


            // PCとenemyの座標が==の場合destroyも可能？上手くいかんかった
            if (skullPos == enemyPos)
            {
                Destroy(enemy);
                Debug.Log("IkeIke");
            }

            yield return new WaitForSeconds(second);

        }
    }

    public float timeCount;
    public int waitingTime;

    private void Update()
    {
        
    }

    public void AttackTime()
    {
        
        timeCount += Time.deltaTime;

        if (timeCount > waitingTime)
        {
            timeCount = 0f;
        }

    }

    public IEnumerator loop2(bool move)
    {
        for (int i = 0; i < time; i++)
        {
            yield return new WaitForSeconds(1f);
            timeCount++;

            if (i == 4)
            {
                print("OK");
                yield break;
            }
        }

        

        
        //timeCount = 0;

        //while (true)
        //{
            
        //    timeCount += 1.0f * Time.deltaTime;

        //    if (timeCount > waitingTime)
        //    {
                
        //        yield break;
        //    }
            

        //}
    }
}
