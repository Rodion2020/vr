using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ChaseState : MonoBehaviour, IFSMState
{
    public FSMStateType StateName { get { return FSMStateType.Chase; } }
    public float MinChaseDistance = 2.0f;
    private Transform Player = null;
    private NavMeshAgent ThisAgent = null;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        ThisAgent = GetComponent<NavMeshAgent>();

    }

    public void OnEnter()
    {
        ThisAgent.isStopped = false;
    }

    public void OnExit()
    {
        ThisAgent.isStopped = true;
    }

    public void DoAction()
    {
        ThisAgent.SetDestination(Player.position);
    }

    public FSMStateType ShouldTransitionToState()
    {
        float DistancetoDest = Vector3.Distance(transform.position, Player.position);
        if (DistancetoDest <= MinChaseDistance)
        {
            return FSMStateType.Attack;
        }
        return FSMStateType.Chase;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
