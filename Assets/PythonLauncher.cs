using System.IO;
using UnityEngine;

[DisallowMultipleComponent]
public class PythonLauncher : MonoBehaviour
{
    void Start()
    {
        // Get the path to the Assets directory
        string projectRootPath = Application.dataPath;

        // Construct the path to the Python script within the Resources folder
        string scriptPath = Path.Combine(projectRootPath, "Resources", "app.py");

        // Navigate to the script path using the 'cd' command
        string cdCmdText = $"/C cd /D {Path.GetDirectoryName(scriptPath)}";

        // Launch the Python script using the 'python' command
        string launchCmdPython = $"python {Path.GetFileName(scriptPath)}";

        // Combine the 'cd' and 'python' commands
        string combinedCmd = $"{cdCmdText} && {launchCmdPython}";

        // Start CMD.exe process with the combined command
        System.Diagnostics.Process.Start("CMD.exe", combinedCmd);
    }
}
