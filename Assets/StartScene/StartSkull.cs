using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSkull : MonoBehaviour
{
    private enum SkullState { STAND, WALK };

    public float speed;
    public float smooth;

    private Animator motion;
    private SkullState state;

    void Start()
    {
        motion = GetComponent<Animator>();
        state = SkullState.STAND;
    }

    void Update()
    {
        Vector3 targetDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (targetDir.magnitude > 0.1)
        {
            Quaternion rotation = Quaternion.LookRotation(targetDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            switch (state)
            {
                case SkullState.STAND:
                    motion.SetBool("StartWalk", true);
                    break;
            }

            //if (state == SkullState.STAND)
            //{
            //    state = SkullState.WALK;
            //    motion.SetBool("StartWalk", true);
            //}
        }
        else
        {
            switch (state)
            {
                case SkullState.WALK:
                    motion.SetBool("StartWalk", false);
                    break;
            }

            //if (state == SkullState.WALK)
            //{
            //    state = SkullState.STAND;
            //    motion.SetBool("StartWalk", false);
            //}
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("StartCube"))
        {
            StartCoroutine(Wait());
        }
        else if (other.gameObject.CompareTag("ExitCube"))
        {
            StartCoroutine(WaitExit());
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    object tagName = other.gameObject.CompareTag("StartCube");

    //    switch (tagName)
    //    {
    //        case "StartCube":
    //            StartCoroutine(Wait());
    //            break;

    //        case "ExitCube":
    //            StartCoroutine(WaitExit());
    //            break;
    //    }
    //}

    IEnumerator Wait()
    {
        print("衝突");
        speed = 0;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync("Game Scene");
        print("スタート");
    }

    IEnumerator WaitExit()
    {
        print("衝突");
        speed = 0;
        yield return new WaitForSeconds(1f);
        UnityEditor.EditorApplication.isPlaying = false;
        // UnityEngine.Application.Quit();
        print("終了");
    }
}
