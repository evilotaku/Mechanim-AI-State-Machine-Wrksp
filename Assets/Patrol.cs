using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : StateMachineBehaviour {

	NavMeshAgent agent;
	GameObject[] waypoints;

	void Awake()
	{		
		waypoints = GameObject.FindGameObjectsWithTag ("waypoint");
	}

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{		
		agent = animator.GetComponent<NavMeshAgent> ();
		Vector3 dest = waypoints [Random.Range (0, waypoints.Length)].transform.position;
		agent.SetDestination(dest);	
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if(agent.remainingDistance < 0.5f)
		{
			agent.SetDestination(waypoints[Random.Range(0, waypoints.Length)].transform.position);
		}
	
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		
	}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
