using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using System.IO;

public class RemoveInternetPermission : IPostprocessBuildWithReport
{
    public int callbackOrder => 0;

    public void OnPostprocessBuild(BuildReport report)
    {
        // Check if the build target is Android
        if (report.summary.platform == BuildTarget.Android)
        {
            // Path to the generated AndroidManifest.xml
            string manifestPath = Path.Combine(report.summary.outputPath, "unityLibrary/src/main/AndroidManifest.xml");

            // Check if the file exists
            if (File.Exists(manifestPath))
            {
                // Read the content of the AndroidManifest.xml
                string content = File.ReadAllText(manifestPath);

                // Remove the internet permissions
                content = content.Replace("<uses-permission android:name=\"android.permission.INTERNET\"/>", "");
                content = content.Replace("<uses-permission android:name=\"android.permission.ACCESS_NETWORK_STATE\"/>", "");

                // Write the modified content back to the AndroidManifest.xml
                File.WriteAllText(manifestPath, content);
                UnityEngine.Debug.Log("Internet permissions removed from AndroidManifest.xml");
            }
            else
            {
                UnityEngine.Debug.LogWarning("AndroidManifest.xml not found at: " + manifestPath);
            }
        }
    }
}
