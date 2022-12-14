// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using UnityEditor;

namespace Microsoft.MixedReality.Toolkit.Dwell.Editor
{
    /// <summary>
    /// Custom profile inspector for the extended dwell profile sample
    /// </summary>
    [CustomEditor(typeof(DwellProfileWithDecay))]
    [Serializable]
    public class DwellProfileWithDecayInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawPropertiesExcluding(this.serializedObject, "timeToAllowDwellResume");

            this.serializedObject.ApplyModifiedProperties();
        }
    }
}
