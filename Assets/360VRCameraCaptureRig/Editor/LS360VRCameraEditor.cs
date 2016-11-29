using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LSToolKit;

[CustomEditor(typeof(LS360VRCamera))]
public class LS360VRCameraEditor : Editor {

    private GUIStyle boxStyle;
    Texture WorldIcon = (Texture)Resources.Load("LS_Logo");

    public override void OnInspectorGUI()
    {
        LS360VRCamera targetCamScript = (LS360VRCamera)target;

        GUILayout.BeginHorizontal();
        GUILayout.Box(WorldIcon, GUILayout.Width(WorldIcon.width), GUILayout.Height(WorldIcon.height), GUILayout.ExpandWidth(true));
        GUILayout.EndHorizontal();
        EditorGUILayout.Space();

        base.OnInspectorGUI();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}




