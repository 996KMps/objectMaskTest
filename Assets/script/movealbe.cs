using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movealbe : MonoBehaviour
{
    NavMeshAgent agent;

    [SerializeField]
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            agent.SetDestination(target.position);
        }
    }
}
