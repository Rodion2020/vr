using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : MonoBehaviour, IFSMState
{
    public FSMStateType StateName { get { return FSMStateType.Attack; } }
    public ParticleSystem WeaponPS = null;
    private Transform ThisPlayer = null;
    public void OnEnter()
    {
        WeaponPS.Play();
    }

    public void OnExit()
    {
        WeaponPS.Stop();
    }

    public void DoAction()
    {
        Vector3 Dir = (ThisPlayer.position - transform.position).normalized;
        Dir.y = 0;
        transform.rotation = Quaternion.LookRotation(Dir, Vector3.up);
    }

    public FSMStateType ShouldTransitionToState()
    {
        return FSMStateType.Attack;
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
