using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public float smooth;

    public float minRange;
    public float maxRange;

    private Animator motion;

    void Start()
    {
        motion = GetComponent<Animator>();
    }
    
    void Update()
    {
        Vector3 targetDir = new Vector3(Random.Range(minRange, maxRange), 0, Random.Range(minRange, maxRange));

        if (targetDir.magnitude > 0.1)
        {
            Quaternion rotation = Quaternion.LookRotation(targetDir);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * smooth);

            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
}
