using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public Transform _target;
	public float _speed = 4f;

	private Vector3 _positions;

	private void Start()
	{
		_positions = _target.InverseTransformPoint(transform.position);
	}

	private void Update()
	{
		var _currentPositions = _target.TransformPoint(_positions);
		transform.position = Vector3.Lerp(transform.position, _currentPositions, _speed * Time.deltaTime);
		var _currentRotations = Quaternion.LookRotation(_target.position - transform.position);
		transform.rotation = Quaternion.Lerp(transform.rotation, _currentRotations, _speed * Time.deltaTime);
	}
}
