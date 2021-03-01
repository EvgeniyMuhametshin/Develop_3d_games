using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	[SerializeField] private Rigidbody _rigiBody;

	private Vector3 _move;
	private static Move _instance;

	public float _speed = 20f;
	public float _turnSpeed = 200f;

	private void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * _speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector3.forward * _speed * Time.deltaTime);
		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up * -_turnSpeed * Time.deltaTime);
		if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up * _turnSpeed * Time.deltaTime);
	}

	private void Awake()
	{
		_instance = this;
	}

	private void FixedUpdate()
	{
		if (_rigiBody == null)
		{ 
			return;
		}

		if (_move.magnitude < 0.01f)
		{ 
			return;
		}
			

		var _velocity = _move * (_speed * Time.deltaTime);
		_rigiBody.velocity = _velocity;
	}
}
