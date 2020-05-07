using UnityEditor;
using UnityEngine;

namespace BuffSystem
{
    
    // Property drawer to make statsMods easier on eyes

    [CustomPropertyDrawer(typeof(StatMod))]
    public class StatModDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var r1 = new Rect(position.x, position.y, 60, position.height);
            var r2 = new Rect(position.x + 70, position.y, 60, position.height);
            var r3 = new Rect(position.x + 140, position.y, 60, position.height);
            EditorGUI.PropertyField(r1, property.FindPropertyRelative("value"), GUIContent.none);
            EditorGUI.PropertyField(r2, property.FindPropertyRelative("type"), GUIContent.none);
            EditorGUI.PropertyField(r3, property.FindPropertyRelative("kind"), GUIContent.none);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }

}
