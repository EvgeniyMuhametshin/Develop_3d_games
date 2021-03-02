using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class GUI_Test_Slider : MonoBehaviour
{
	private float _slider = 0.0f;
	private string _message;

	private void OnGUI()
	{
		_slider = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), _slider, 0.0f, 10.0f);
		if (_slider == 10.0)
			_message = "HP Very high";
		if (_slider == 0.0)
			_message = "HP Very Low";
		GUI.Label(new Rect(220, 10, 100, 30), _message);
	}
}
