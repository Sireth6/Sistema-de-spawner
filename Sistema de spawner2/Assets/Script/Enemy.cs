using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;

    GameObject target;

    private void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }    

    private void Update ()
    {
        GoToTarget();
    }

    private void GoToTarget()
    {
        agent.SetDestination(target.transform.position);
    }
}
