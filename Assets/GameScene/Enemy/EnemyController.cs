using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public Transform skull;
    NavMeshAgent agent;

    GameObject item;
    ItemController script;

    GameObject Skull;
    StartSkull SScript;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        item = GameObject.Find("Items");
        script = item.GetComponent<ItemController>();

        Skull = GameObject.Find("Skull");
        SScript = Skull.GetComponent<StartSkull>();
    }

    void Update()
    {
        agent.SetDestination(skull.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Skull")
            && script.isRunningCount == 0)
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
}
