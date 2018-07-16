#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(buildinginitialize))]
public class buildinginitializeeditor : Editor

{
    private buildinginitialize myTarget;
    private SerializedObject soTarget;
    private SerializedProperty saveload;
    //budynki
    //cop_1
    private SerializedProperty cop_1;
    private SerializedProperty cop_1ac;
    private SerializedProperty cop_1ne;
    //antena_1
    private SerializedProperty antena_1;
    private SerializedProperty antena_1ac;
    // private SerializedProperty antena_1ne;
    //antena_2
    private SerializedProperty antena_2;
    private SerializedProperty antena_2ac;
    //private SerializedProperty antena_2ne;
    //antena_3
    //private SerializedProperty antena_3;
    //private SerializedProperty antena_3ac;
    //private SerializedProperty antena_3ne;
    //antena_4
    //private SerializedProperty antena_4;
    // private SerializedProperty antena_4ac;
    //private SerializedProperty antena_4ne;
    //antena_5
    //private SerializedProperty antena_5;
    //private SerializedProperty antena_5ac;
    // private SerializedProperty antena_5ne;
    //ulepszenia
    //table_1
    private SerializedProperty table_1;
    private SerializedProperty table_1ac;
    // private SerializedProperty table_1ne;

    private void OnEnable()
    {
        myTarget = (buildinginitialize)target;
        soTarget = new SerializedObject(target);
        saveload = soTarget.FindProperty("load_save");
        //budynki
        //cop_1
        cop_1 = soTarget.FindProperty("cop_1");
        cop_1ac = soTarget.FindProperty("cop_1ac");
        // cop_1ne = soTarget.FindProperty("cop_1ne");
        //antena_1
        antena_1 = soTarget.FindProperty("antena_1");
        antena_1ac = soTarget.FindProperty("antena_1ac");
        // antena_1ne = soTarget.FindProperty("antena_1ne");
        //antena_2
        antena_2 = soTarget.FindProperty("antena_2");
        antena_2ac = soTarget.FindProperty("antena_2ac");
        // antena_2ne = soTarget.FindProperty("antena_2ne");
        //antena_3
        //antena_3 = soTarget.FindProperty("antena_3");
        // antena_3ac = soTarget.FindProperty("antena_3ac");
        // antena_3ne= soTarget.FindProperty("antena_3ne");
        //antena_4
        //antena_4 = soTarget.FindProperty("antena_4");
        // antena_4ac = soTarget.FindProperty("antena_4ac");
        // antena_4ne = soTarget.FindProperty("antena_4ne");
        //antena_5
        // antena_5 = soTarget.FindProperty("antena_5");
        //antena_5ac = soTarget.FindProperty("antena_5ac");
        //antena_5ne = soTarget.FindProperty("antena_5ne");
        //ulepszenia
        //table_1_cop
        table_1 = soTarget.FindProperty("table_1");
        table_1ac = soTarget.FindProperty("table_1ac");
        //table_1ne = soTarget.FindProperty("table_1ne");
    }

    public override void OnInspectorGUI()
    {
        soTarget.Update();
        EditorGUI.BeginChangeCheck();
        EditorGUILayout.PropertyField(saveload);
        myTarget.currentTab = GUILayout.Toolbar(myTarget.currentTab, new string[] { "Budynki", "Ulepszenia" });

        switch (myTarget.currentTab)
        {
            case 0:
                EditorGUILayout.LabelField("Cop_1");
                EditorGUILayout.PropertyField(cop_1);
                EditorGUILayout.PropertyField(cop_1ac);
                // EditorGUILayout.PropertyField(cop_1ne);
                EditorGUILayout.LabelField("antena_1");
                EditorGUILayout.PropertyField(antena_1);
                EditorGUILayout.PropertyField(antena_1ac);
                // EditorGUILayout.PropertyField(antena_1ne);
                EditorGUILayout.LabelField("antena_2");
                EditorGUILayout.PropertyField(antena_2);
                EditorGUILayout.PropertyField(antena_2ac);
                // EditorGUILayout.PropertyField(antena_2ne);
                //  EditorGUILayout.LabelField("antena_3");
                //  EditorGUILayout.PropertyField(antena_3);
                //  EditorGUILayout.PropertyField(antena_3ac);
                //EditorGUILayout.PropertyField(antena_3ne);
                // EditorGUILayout.LabelField("antena_4");
                // EditorGUILayout.PropertyField(antena_4);
                // EditorGUILayout.PropertyField(antena_4ac);
                //EditorGUILayout.PropertyField(antena_4ne);
                //EditorGUILayout.LabelField("antena_5");
                // EditorGUILayout.PropertyField(antena_5);
                //EditorGUILayout.PropertyField(antena_5ac);
                //EditorGUILayout.PropertyField(antena_5ne);

                break;
            case 1:
                EditorGUILayout.LabelField("Table_1");
                EditorGUILayout.PropertyField(table_1);
                EditorGUILayout.PropertyField(table_1ac);
                //EditorGUILayout.PropertyField(table_1ne);
                break;
        }
        if (EditorGUI.EndChangeCheck())
        {
            soTarget.ApplyModifiedProperties();
            GUI.FocusControl(null);

        }
    }
}
#endif