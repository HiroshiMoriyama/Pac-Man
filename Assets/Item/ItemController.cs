using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int time;
    public int timeCount;
    
    public IEnumerator loop(bool move)
    {
        timeCount = 0;

        for (int i = 0; i < time; i++)
        {
            yield return new WaitForSeconds(1f);
            timeCount++;

            if (i == 4)
            {
                timeCount = -1;
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
