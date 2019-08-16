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

    public int MCCount;
    public int MCNum;
    private int MCColor = 5; // MusicCubeの種類（5色）
    private int MCWall = 4; // MusicCubeの壁側エリア数
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
        MCNum = MCScript.cubeNum * MCColor * MCWall
            + MCScript.UpperMiddleCubeNum * MCColor
            + MCScript.MiddleCubeNum * MCColor
            + MCScript.LowerMiddleCubeNum * MCColor;
    }

    void Update()
    {
        // 移動
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

        // クリアシーンへ遷移
        if (MCCount >= MCNum)
        {
            StartCoroutine(Clear());
        }
    }

    // 各オブジェクト接触時の挙動
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
            && script.isRunningCount != 0
            && MCCount < MCNum)
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

    IEnumerator Clear()
    {
        print("衝突");
        speed = 0;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("ClearScene");
        print("遷移");
    }
}
