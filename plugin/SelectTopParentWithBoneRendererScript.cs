using UnityEditor;
using UnityEngine;

using UnityEngine.Animations.Rigging;
public class SelectTopParentWithBoneRendererScript : UnityEditor.Editor
{
    [MenuItem("Tools/Select Top Parent %t")]
    public static void SelectTopParentWithBoneRender(){
        Transform topTransform;
        topTransform = Selection.activeTransform;
        while(topTransform.parent != null ){
            topTransform = topTransform.parent;
            //遇到有绘画骨骼的就选择这个父物体即可
            if(topTransform.gameObject.GetComponent<BoneRenderer>() != null)
                break;
        }
        //Debug.Log(topTransform.gameObject.name);
        Selection.activeTransform = topTransform;
    }
}
