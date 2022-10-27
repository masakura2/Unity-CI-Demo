using UnityEditor;

// ReSharper disable once CheckNamespace
// ReSharper disable once UnusedType.Global
public static class Export
{
    // ReSharper disable once UnusedMember.Global
    public static void Android()
    {
        EditorUserBuildSettings.exportAsGoogleAndroidProject = true;

        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes,
            "build/android",
            BuildTarget.Android,
            BuildOptions.None);
    }
}
