using UnityEditor;
using UnityEngine;

namespace BuffSystem
{

    // Property drawer to make Stats easier on eyes

    [CustomPropertyDrawer(typeof(Stat))]
    public class StatDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var w = 50;
            var r1 = new Rect(position.x, position.y, w, position.height);
            var r2 = new Rect(r1.x + w, position.y, w, position.height);
            var r3 = new Rect(r2.x + w, position.y, w, position.height);
            var r4 = new Rect(r3.x + w, position.y, w, position.height);
            EditorGUI.PropertyField(r1, property.FindPropertyRelative("type"), GUIContent.none);
            EditorGUI.PropertyField(r2, property.FindPropertyRelative("value"), GUIContent.none);
            EditorGUI.PropertyField(r3, property.FindPropertyRelative("flatMods"), GUIContent.none);
            EditorGUI.PropertyField(r4, property.FindPropertyRelative("percentMods"), GUIContent.none);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
    
}