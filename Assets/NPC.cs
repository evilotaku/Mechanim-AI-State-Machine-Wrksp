using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour 
{

	Animator anim;
	GameObject player;

	// Use this for initialization
	void Start () 
	{

		anim = GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () 
	{		
		See ();
		Hear ();
		Smell ();
	}

	void See()
	{
	}

	void Hear()
	{	
		anim.SetFloat ("distance", Vector3.Distance (transform.position, player.transform.position));	
	}

	void Smell()
	{
	}

	public void Attack()
	{
	}
}
