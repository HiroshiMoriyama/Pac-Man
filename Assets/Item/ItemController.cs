using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{ 
    public int isRunningCount; 
    public int time;
    
    public IEnumerator loop()
    {
        isRunningCount++;
        print("start");

        for (int i = 0; i < time; i++)
        {
            yield return new WaitForSeconds(1f);
        }

        isRunningCount--;
        print("end");

        //    timeCount = -1;

        //{
        //    yield break;
        //}




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
