using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(EditorFunctionClass))]
//[ExecuteInEditMode] �ִ� ��¦ �׳� �����Ϳ����� �ڵ尡 ����Ǵ� ��.
public class EditorStudy : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        EditorFunctionClass generator = (EditorFunctionClass)target;

        if (GUILayout.Button("Generate Prefab"))
        {
            generator.GeneratePrefab();
        }
        if (GUILayout.Button("�ǳ�"))
        {
            Debug.Log("����");
        }
    }


}
