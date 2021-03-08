using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class GUI_Test_SelectionGrid : MonoBehaviour
{   private int _selectionGridInt = 0;
    private string[] selectionStrings = { "Grid 1", "Grid 2", "Grid 3", "Grid 4" };

	private void OnGUI()
	{
       _selectionGridInt = GUI.SelectionGrid(new Rect(25, 25, 300, 60), _selectionGridInt, selectionStrings, 2);
    }
}
