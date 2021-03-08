using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSetting : MonoBehaviour
{
	[SerializeField] Color _sky, _equator, _ground, _sunColor;
	[SerializeField] float _rotateSpeed;

	Light _sun;

	private void Start()
	{
		_sun = GetComponent<Light>();
	}
	private void Update()
	{
		RenderSettings.ambientSkyColor = _sky;
		RenderSettings.ambientGroundColor = _ground;
		RenderSettings.ambientEquatorColor = _equator;

		_sun.color = _sunColor;

		transform.Rotate(transform.right, _rotateSpeed, Space.Self);
	}
}
