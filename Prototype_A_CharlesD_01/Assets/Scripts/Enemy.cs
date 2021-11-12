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
	public bool EnemyInLightRange;
	

	private Collider playerCollider;

	private Collider lightCollider;

	#endregion

	private void Awake()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		agent = GetComponent<NavMeshAgent>();

		//ply = GameObject.FindGameObjectWithTag("Player");

		//NavColRange = GetComponent<NavCollider>().Radius --- trying to get the walkpoint to be inside this collider so AI isnt to far from player
	}

	private void Update()
	{

		playerInSightRange = Physics.CheckSphere(transform.position, SightRange, whatIsPlayer);


		// Change function depending on lightrange condition
		if (!playerInSightRange)
		{
			Patroling();
			Debug.Log("Patroling");
		}

		if (EnemyInLightRange)
		{
			

			Debug.Log("Exiting");
		}

		if (playerInSightRange)
		{
			ChasePlayer(player.position);
			Debug.Log("Chasing");
		}

		
		

	}

	//check if Ai in player Light range

	private void OnTriggerEnter(Collider other)
	{
		EnemyInLightRange = true;
	}

	
	private void OnTriggerExit(Collider other)
	{
		EnemyInLightRange = false;
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
		// Ai walkpoint is now the players position in other words it is now chasing you. + the Ai mesh turns towards the player.

		agent.SetDestination(player.position);

		if (EnemyInLightRange)
		{
			Patroling();

		}
			

		//player.transform.positionLookAt(player);

	}

	private void Exiting()
	{

		// I made this function has a way to make the AI exit the light radius to test how the game would work the other way around ( Monster scared of light).

		

		agent.SetDestination(walkPoint);

		Debug.Log("Exiting");


	}

	

	#endregion

}
