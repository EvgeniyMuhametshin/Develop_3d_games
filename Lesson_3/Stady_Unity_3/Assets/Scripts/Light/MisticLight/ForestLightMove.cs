using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ForestLightMove : MonoBehaviour
{
    [SerializeField] public NavMeshAgent _navMeshAgent;
    [SerializeField] public Transform[] _wayPoints;

    int _currentWayPointIndex;

	private void Start()
	{
		_navMeshAgent.SetDestination(_wayPoints[0].position);
	}

	private void Update()
	{
		if (_navMeshAgent.remainingDistance < _navMeshAgent.stoppingDistance)
		{
			_currentWayPointIndex = (_currentWayPointIndex + 1) % _wayPoints.Length;
			_navMeshAgent.SetDestination(_wayPoints[_currentWayPointIndex].position);
		}
	}
}
