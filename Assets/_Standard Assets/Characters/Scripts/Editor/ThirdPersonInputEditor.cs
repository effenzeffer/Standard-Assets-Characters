﻿using StandardAssets.Characters.ThirdPerson;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    /// <summary>
    /// Custom Editor for <see cref="ThirdPersonInput"/> that will hide <see cref="ThirdPersonInput.m_LocomotionInputSmoother"/> if
    /// <see cref="ThirdPersonInput.m_UseInputSmoother"/> is false;
    /// </summary>
    [CustomEditor(typeof(ThirdPersonInput))]
    public class ThirdPersonInputEditor : UnityEditor.Editor
    {
        protected const string k_UseInputSmoother = "useInputSmoother",
                               k_LocomotionInputSmoother = "locomotionInputSmoother";

        public override void OnInspectorGUI()
        {
            var useInputSmoother = serializedObject.FindProperty(k_UseInputSmoother);
            if (useInputSmoother != null && !useInputSmoother.boolValue)
            {
                DrawPropertiesExcluding(serializedObject, k_LocomotionInputSmoother);
            }
            else
            {
                base.OnInspectorGUI();
            }

            if (GUI.changed)
            {
                serializedObject.ApplyModifiedProperties();
            }
        }
    }
}