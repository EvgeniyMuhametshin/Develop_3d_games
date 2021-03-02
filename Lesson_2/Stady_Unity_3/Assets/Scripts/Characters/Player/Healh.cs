using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healh : MonoBehaviour
{
	private float _healf;
	private string _message;

	private void OnGUI()
	{
		_healf = GUI.HorizontalSlider(new Rect(30, 30, 110, 35), _healf, 0.0f, 10.0f);

		if (_healf == 10.0)
			_message = "HP Very high";
		if (_healf == 0.0)
			_message = "HP Very low";
		if (_healf > 0.0 & _healf < 10.0)
			_message = "HP Very middle";
		GUI.Label(new Rect(40,40,130,45), _message);
	}
}
