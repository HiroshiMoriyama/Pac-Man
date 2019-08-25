﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkullController : MonoBehaviour
{
    private enum SkullState {  STAND, WALK };

    public float speed;         // 移動速度
    public float smooth;        // 方向転換のスムーズさ

    private Animator motion;
    private SkullState state;

    GameObject item;
    ItemController script;

    public int MCCount;      // MusicCube取得数
    public int MCNum;        // MusicCube合計数
    private int MCColor = 5; // MusicCubeの種類（5色）
    private int MCWall = 4;  // MusicCubeの壁側エリア数
    GameObject musicCube;
    MusicCubeSpawner MCScript;

    // Music CubeのSEオブジェクトのコンポーネントを格納する変数
    AudioSource audioA;
    AudioSource audioH;
    AudioSource audioD;
    AudioSource audioE;
    AudioSource audioFsherp;

    // Music CubeのSEオブジェクトをFind
    GameObject CubeA;
    GameObject CubeH;
    GameObject CubeD;
    GameObject CubeE;
    GameObject CubeFsherp;

    void Start()
    {
        motion = GetComponent<Animator>();
        state = SkullState.STAND;

        item = GameObject.Find("Items");
        script = item.GetComponent<ItemController>();

        musicCube = GameObject.Find("Music Cubes");
        MCScript = musicCube.GetComponent<MusicCubeSpawner>();

        //  MusicCube合計数をMCNumに代入
        MCNum = MCScript.cubeNum * MCColor * MCWall
            + MCScript.UpperMiddleCubeNum * MCColor
            + MCScript.MiddleCubeNum * MCColor
            + MCScript.LowerMiddleCubeNum * MCColor;

        // Music CubeのSEオブジェクトからコンポーネントを格納
        CubeA = GameObject.Find("CubeA");
        audioA = CubeA.gameObject.GetComponent<AudioSource>();
        CubeH = GameObject.Find("CubeH");
        audioH = CubeH.gameObject.GetComponent<AudioSource>();
        CubeD = GameObject.Find("CubeD");
        audioD = CubeD.gameObject.GetComponent<AudioSource>();
        CubeE = GameObject.Find("CubeE");
        audioE = CubeE.gameObject.GetComponent<AudioSource>();
        CubeFsherp = GameObject.Find("CubeF#");
        audioFsherp = CubeFsherp.gameObject.GetComponent<AudioSource>();
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

            switch (state)
            {
                case SkullState.STAND:
                    state = SkullState.WALK;
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
                    state = SkullState.STAND;
                    motion.SetBool("StartWalk", false);
                    break;
            }

            //if (state == SkullState.WALK)
            //{
            //    state = SkullState.STAND;
            //    motion.SetBool("StartWalk", false);
            //}
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
        if (other.gameObject.CompareTag("MCubeA"))
        {
            Music.QuantizePlay(audioA);
            other.gameObject.SetActive(false);
            MCCount++;
        }
        else if (other.gameObject.CompareTag("MCubeH"))
        {
            Music.QuantizePlay(audioH);
            other.gameObject.SetActive(false);
            MCCount++;
        }
        else if (other.gameObject.CompareTag("MCubeD"))
        {
            Music.QuantizePlay(audioD);
            other.gameObject.SetActive(false);
            MCCount++;
        }
        else if (other.gameObject.CompareTag("MCubeE"))
        {
            Music.QuantizePlay(audioE);
            other.gameObject.SetActive(false);
            MCCount++;
        }
        else if (other.gameObject.CompareTag("MCubeFsherp"))
        {
            Music.QuantizePlay(audioFsherp);
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
