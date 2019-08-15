using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform skull;
    NavMeshAgent agent;

    GameObject item;
    ItemController script;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        item = GameObject.Find("Items");
        script = item.GetComponent<ItemController>();
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
        }
    }
}
