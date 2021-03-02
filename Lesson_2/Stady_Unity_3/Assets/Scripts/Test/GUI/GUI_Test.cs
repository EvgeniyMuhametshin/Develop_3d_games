using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Test : MonoBehaviour
{
    private string _message;

	private void OnGUI()
	{
		GUI.Box(new Rect(10,10,200,140), "Main Menu");
		if (GUI.Button(new Rect(20, 40, 180, 30), "Open"))
			_message = "Open";
		if (GUI.Button(new Rect(20, 75, 180, 30), "Save"))
			_message = "Save";
		if (GUI.Button(new Rect(20, 110, 180, 30), "Load"))
			_message = "Load";
		GUI.Label(new Rect(220,10,100,30), _message);
	}


}
