using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


class GUI_Test_HP : MonoBehaviour
{
	public Texture2D _icon;

	private void OnGUI()
	{
		GUI.Box(new Rect(50,50,100,100), new GUIContent("HP", _icon));
	}
}

