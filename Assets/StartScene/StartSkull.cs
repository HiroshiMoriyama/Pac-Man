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
    }
}
