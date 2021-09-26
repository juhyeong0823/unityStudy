using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(EditorFunctionClass))]
//[ExecuteInEditMode] 애는 살짝 그냥 에디터에서도 코드가 실행되는 거.
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
        if (GUILayout.Button("되나"))
        {
            Debug.Log("뭐지");
        }
    }


}
