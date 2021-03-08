using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class GUI_Test_2 : MonoBehaviour
{
	private void OnGUI()
	{
		GUI.Box(new Rect(0,0,100,50), "Top-left");
		GUI.Box(new Rect(Screen.width - 100, 0, 100, 50), "Top-right");
		GUI.Box(new Rect(0, Screen.height - 50, 100, 50), "Bottom-left");
		GUI.Box(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Bottom-right");
	}
}

