using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkullController : MonoBehaviour
{
    private enum SkullState {  STAND, WALK };

    public float speed;
    public float smooth;

    private Animator motion;
    private SkullState state;

    GameObject item;
    ItemController script;

    private int MCCount;
    GameObject musicCube;
    MusicCubeSpawner MCScript;

    void Start()
    {
        motion = GetComponent<Animator>();
        state = SkullState.STAND;

        item = GameObject.Find("Items");
        script = item.GetComponent<ItemController>();

        musicCube = GameObject.Find("Music Cubes");
        MCScript = musicCube.GetComponent<MusicCubeSpawner>();
    }

    void Update()
    {
        Vector3 targetDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (targetDir.magnitude > 0.1)
        {
            Quaternion rotation = Quaternion.LookRotation(targetDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

            if (state == SkullState.STAND)
            {
                state = SkullState.WALK;
                motion.SetBool("StartWalk", true);
            }
        }
        else
        {
            if (state == SkullState.WALK)
            {
                state = SkullState.STAND;
                motion.SetBool("StartWalk", false);
            }
        }

        if (MCCount <= MCScript.cubeNum
            && MCCount <= MCScript.UpperMiddleCubeNum
            && MCCount <= MCScript.MiddleCubeNum
            && MCCount <= MCScript.LowerMiddleCubeNum)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MusicCube"))
        {
            other.gameObject.SetActive(false);
            MCCount++;
        }
        else if (other.gameObject.CompareTag("Attack Item"))
        {
            other.gameObject.SetActive(false);

            script.StartCoroutine(script.loop());
        }
        else if (other.gameObject.CompareTag("Enemy") 
            && script.isRunningCount != 0)
        {
            other.gameObject.SetActive(false);
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        print("衝突");
        speed = 0;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("GameOverScene");
        print("遷移");
    }
}
