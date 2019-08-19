using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRoll : MonoBehaviour
{
    [SerializeField]
    private float scrollSpeed;

    [SerializeField]
    private float limitPosition;

    private bool isStopEndRoll;

    void Update()
    {
        if (isStopEndRoll)
        {
            StartCoroutine(StartScene());
        }
        else
        {
            if (transform.position.y <= limitPosition)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + scrollSpeed * Time.deltaTime);
            }
            else
            {
                isStopEndRoll = true;
            }
        }
    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(2f);

        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Start Scene");
        }
    }
}
/*  テキスト



  
<size=50>Producer</size>

Hiroshi Moriyama



<size=50>Director</size>

Hiroshi Moriyama



<size=50>Music</size>

Hiroshi Moriyama



<size=50>Programmer</size>

Hiroshi Moriyama



<size=50>Special Thanks</size>

GFTD



<size=50>...And All Hiroshi Moriyama</size>














<size=50>THE END</size>
    */
