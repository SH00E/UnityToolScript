using UnityEditor;
using UnityEngine;
public class SelectTopParentScript : UnityEditor.Editor
{
    [MenuItem("Tools/Select Top Parent %t")]
    public static void SelectTopParent(){
        Transform topTransform;
        topTransform = Selection.activeTransform;
        while(topTransform.parent != null ){
            topTransform = topTransform.parent;
        }
        //Debug.Log(topTransform.gameObject.name);
        Selection.activeTransform = topTransform;
    }
}
