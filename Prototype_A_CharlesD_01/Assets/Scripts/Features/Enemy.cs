using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
	#region variables

	public NavMeshAgent Agent;

	public Transform Player;

	public LayerMask whatIsGround, whatIsPlayer;

	GameObject ply;

	//Material

	public Material MaterialEyes01;
	public Material MaterialEyes02;

	public GameObject Eyes;
	public GameObject Eyes02;


	//Patroling

	public Vector3 WalkPoint;
	bool walkPointSet;
	public float WalkPointRange;


	//States

	public float SightRange;
	public bool PlayerInSightRange;
	public bool EnemyInLightRange;
	

	private Collider playerCollider;

	private Collider lightCollider;

	#endregion

	#region Messages

	private void Awake()
	{
		Player = GameObject.FindGameObjectWithTag("Player").transform;
		Agent = GetComponent<NavMeshAgent>();
	}

	private void Update()
	{
		PlayerInSightRange = Physics.CheckSphere(transform.position, SightRange, whatIsPlayer);

		// Change function depending on lightrange condition
		if (!PlayerInSightRange)
		{
			Patroling();
			Debug.Log("Patroling");
		}

		if (PlayerInSightRange)
		{
			ChasePlayer(Player.position);
			Debug.Log("Chasing");
		}

		if (EnemyInLightRange)
		{
			Patroling();
		}
	}

	//check if Ai in player Light range

	private void OnTriggerStay(Collider other)
	{
			EnemyInLightRange = true;
	}
	
	private void OnTriggerExit(Collider other)
	{
			EnemyInLightRange = false;
	}

	#endregion

	#region Functions

	private void Patroling()
	{
		Debug.Log("Im Good BYE");

		// ai searching for new spot to walk to

		if (!walkPointSet) SearchWalkPoint();

		if (walkPointSet)
			Agent.SetDestination(WalkPoint);

		Vector3 distanceToWalkPoint = transform.position - WalkPoint;

		//WalkpointReached and distance between walkpoint

		if (distanceToWalkPoint.magnitude < 5f)
			walkPointSet = false;

		//Material change

		Eyes.GetComponent<MeshRenderer>().material = MaterialEyes01;
		Eyes02.GetComponent<MeshRenderer>().material = MaterialEyes01;
	}

	private void SearchWalkPoint()
	{
		//calculate random point in range  
		float randomZ = Random.Range(-WalkPointRange, WalkPointRange);
		float randomX = Random.Range(-WalkPointRange, WalkPointRange);

		WalkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
		if (Physics.Raycast(WalkPoint, -transform.up, 2f, whatIsGround))
			walkPointSet = true;
	}

	private void ChasePlayer(Vector3 pos)
	{
		// Ai walkpoint is now the players position in other words it is now chasing you.
		if (!EnemyInLightRange)
		{
			Agent.SetDestination(Player.position);

			Eyes.GetComponent<MeshRenderer>().material = MaterialEyes02;
			Eyes02.GetComponent<MeshRenderer>().material = MaterialEyes02;

			Debug.Log("Chasing You Bro");
		}
	}

	#endregion
}
