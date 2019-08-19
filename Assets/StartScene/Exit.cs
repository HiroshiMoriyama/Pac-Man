using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    //GameObject Skull;
    //StartSkull SScript;

    //private void Start()
    //{
    //    Skull = GameObject.Find("Skull");
    //    SScript = Skull.GetComponent<StartSkull>();
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Skull"))
    //    {
    //        StartCoroutine(Wait());
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Skull"))
        {
            for (int i = 0; i < 10; i++)
            {
                transform.Rotate(new Vector3(0, 20, 0));
            }
        }
    }

    //IEnumerator Wait()
    //{
    //    print("衝突");
    //    SScript.speed = 0;
    //    yield return new WaitForSeconds(1f);
    //    UnityEditor.EditorApplication.isPlaying = false;
    //    // UnityEngine.Application.Quit();
    //    print("終了");
    //}
}
