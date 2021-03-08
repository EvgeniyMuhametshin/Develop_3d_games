#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorizeTool : EditorWindow
{
    [MenuItem("Tools/ColorizeTool")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(ColorizeTool));
    }

    private Color _objectColor;
    private GameObject _obj = null;

    void OnGUI()
    {
		GUILayoutOption[] allowSceneObjects = null;
		_obj = EditorGUILayout.ObjectField(_obj, typeof(GameObject), allowSceneObjects) as GameObject;

        if (_obj != null)
        {
            _obj.GetComponent<Renderer>().sharedMaterial.color = _objectColor;
        }

        _objectColor = RGBSlider(new Rect(10, 50, 200, 20), _objectColor);
    }

    Color RGBSlider(Rect screenRect, Color rgba)
    {
        rgba.r = LabelSlider(screenRect, rgba.r, 1.0f, "Red");
        screenRect.y += 20;
        rgba.g = LabelSlider(screenRect, rgba.g, 1.0f, "Green");
        screenRect.y += 20;
        rgba.b = LabelSlider(screenRect, rgba.b, 1.0f, "Blue");
        screenRect.y += 20;
        rgba.a = LabelSlider(screenRect, rgba.a, 1.0f, "Alpha component");
        return rgba;
    }

    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, string labelText)
    {
        float sliderMinValue = 0.0f;
        GUI.Label(screenRect, labelText);
        screenRect.x += screenRect.width;
        sliderValue = GUI.HorizontalSlider(screenRect, sliderValue, sliderMinValue, sliderMaxValue);
        return sliderValue;
    }
}

#endif