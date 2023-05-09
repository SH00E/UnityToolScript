using UnityEditor;
public class LockInspectorScript : UnityEditor.Editor
{
    [MenuItem("Tools/Toggle Inspector Lock %l")] // Ctrl + L
    // 也就是当你用Ctrl+L，会打开Tools的这个脚本，然后这个脚本的功能并不是创建Inspector
    //而是锁定当前的Inspector
    //应该就是后面的这个%l起作用
     public static void ToggleInspectorLock()
     {
         ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
         ActiveEditorTracker.sharedTracker.ForceRebuild();
     }
}
