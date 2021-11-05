using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	#region variables

	public NavMeshAgent agent;

	public Transform player;

	public LayerMask whatIsGround, whatIsPlayer;

	GameObject ply;


	//Patroling
	public Vector3 walkPoint;
	bool walkPointSet;
	public float walkPointRange;


	//States
	public float SightRange;
	public bool playerInSightRange;
	public bool playerInLightRange;


	#endregion

	private void Awake()
	{
		player = GameObject.Find("Player").transform;
		agent = GetComponent<NavMeshAgent>();

		ply = GameObject.FindGameObjectWithTag("Player");

		//NavColRange = GetComponent<NavCollider>().Radius --- trying to get the walkpoint to be inside this collider so AI isnt to far from player

	}

	private void Update()
	{

		// Change function depending on lightrange condition
		if (playerInSightRange) Patroling();
		{
			Debug.Log("Patroling");
		}

		if (playerInLightRange) Exiting();
		{
			Debug.Log("Exiting");
		}

		if (!playerInLightRange) ChasePlayer(ply.transform.position);
		{
			Debug.Log("Chasing");
		}



		
		// seems like the player.position isnt updating causing the bug where ai just lays down on initial player positon


	}

		//check if Ai in player Light range

	private void OnTriggerStay(Collider LightCol)  
	{
		playerInLightRange = true;

	}

	private void OnTriggerExit(Collider LightCol)
	{
		playerInLightRange = false;

	}


	#region Functions

	private void Patroling()
	{

		// ai searching for new spot to walk to

		if (!walkPointSet) SearchWalkPoint();

		if (walkPointSet)
			agent.SetDestination(walkPoint);

		Vector3 distanceToWalkPoint = transform.position - walkPoint;

		//WalkpointReached and distance between walkpoint

		if (distanceToWalkPoint.magnitude < 5f)
			walkPointSet = false;


	}

	private void SearchWalkPoint()
	{
		//calculate random point in range;  ---- Here I need to restrict range inside collider
		float randomZ = Random.Range(-walkPointRange, walkPointRange);
		float randomX = Random.Range(-walkPointRange, walkPointRange);

		walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
		if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
			walkPointSet = true;
	}

	private void ChasePlayer(Vector3 pos)
	{
		// Ai walkpoint is now the players position in other words it is now chasing you. + the Ai mesh turns towrads the player.

		agent.SetDestination(pos);

		transform.LookAt(player);

	}

	     private void Exiting()
	{

		// I made this function has a way to make the AI exit the light radius to test how the game would work the other way around ( Monster scared of light).

		agent.SetDestination(walkPoint);

		Debug.Log("Exiting");

	
	}

	#endregion 

}
