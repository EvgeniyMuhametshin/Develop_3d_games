using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class GUI_Test_Group : MonoBehaviour
{
	private void OnGUI()
	{
		GUI.BeginGroup(new Rect(10, 10, 200, 200));
		GUI.Label(new Rect(0, 0, 50, 20), "Hello");
		GUI.Label(new Rect(0, 25, 50, 20), "World!");
		GUI.EndGroup();
	}
}

