using System.Diagnostics;
using UnityEngine;

public class PythonLauncher : MonoBehaviour
{
    void Start()
    {
        LaunchPythonScript();
    }

    void LaunchPythonScript()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "python";
        startInfo.Arguments = "Resources/app.py";
        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        startInfo.CreateNoWindow = true;

        using (Process process = new Process())
        {
            process.StartInfo = startInfo;
            process.OutputDataReceived += (sender, args) => Debug.Log(args.Data);

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
        }
    }
}