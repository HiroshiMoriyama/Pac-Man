using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public enum EnemyState { STAND, WALK };

    private Animator motion;
    private EnemyState state;

    public Transform skull;
    public NavMeshAgent agent;

    GameObject item;
    ItemController script;

    GameObject Skull;
    SkullController SkullScript;

    void Start()
    {
        motion = GetComponent<Animator>();
        state = EnemyState.STAND;

        agent = GetComponent<NavMeshAgent>();

        item = GameObject.Find("Items");
        script = item.GetComponent<ItemController>();

        Skull = GameObject.Find("Skull");
        SkullScript = Skull.GetComponent<SkullController>();
    }

    void Update()
    {
        StartCoroutine(MoveStart());
        //agent.SetDestination(skull.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Skull")
            && script.isRunningCount == 0
            && SkullScript.MCCount < SkullScript.MCNum)
        {
            other.gameObject.SetActive(false);
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        print("衝突");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("GameOverScene");
        print("遷移");
    }

    IEnumerator MoveStart()
    {
        yield return new WaitForSeconds(4.05f);

        switch (state)
        {
            case EnemyState.STAND:
                state = EnemyState.WALK;
                motion.SetBool("StartRun", true);
                break;
        }
        
        agent.SetDestination(skull.position);
    }
}
