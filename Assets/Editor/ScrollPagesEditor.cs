using UnityEditor;
using UnityEditor.UI;
 
[CustomEditor(typeof(ScrollPages))]
public class ScrollPagesEditor : ScrollRectEditor
{
    public override void OnInspectorGUI()
    {
        // 内部キャッシュから値をロードする
        serializedObject.Update();
 
        // 元々のインスペクタ内容を記述.
        base.OnInspectorGUI();
 
        // プロパティを取得する
        var pageNumber = serializedObject.FindProperty("PageNumber");
        var thresholdValue = serializedObject.FindProperty("ThresholdValue");
 
 
        // プロパティをインスペクタから編集できるように設定
        EditorGUILayout.PropertyField(pageNumber);
        EditorGUILayout.PropertyField(thresholdValue);
 
        // 内部キャッシュに値を保存する
        serializedObject.ApplyModifiedProperties();
    }
}