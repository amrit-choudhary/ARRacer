using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ObstacleSO))]
public class ObstacleSOInspector : Editor {

    ObstacleSO obstacleSO;

    public void OnEnable() {
        obstacleSO = (ObstacleSO)target;
    }

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        EditorGUILayout.Space();
        
        EditorGUILayout.LabelField(Convert(0) + Convert(1) + Convert(2));
        EditorGUILayout.LabelField(Convert(3) + Convert(4) + Convert(5));
        EditorGUILayout.LabelField(Convert(6) + Convert(7) + Convert(8));
    }

    private string Convert(int index) {
        if (obstacleSO.obstacle.list[index])
            return "\u2588" + "\u0020";
        else
            return "\u2000" + "\u2000";
    }

}
