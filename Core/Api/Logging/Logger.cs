/*
 * Filename: Logger.cs
 * Created Date: Tuesday, April 7th 2026, 1:25:28 am
 * Author: Preston
 * 
 * Description: A logging class to make the logs more fancy.
 */

using System.Diagnostics;

namespace CircuitScriptGenerator.Core.Api.Logging;

public enum LogLevel
{
    Debug,
    Trace,
    Warn,
    Error
}

public static class Logger
{
    public static void Log(string script, string message, LogLevel logLevel = LogLevel.Debug)
    {
        var currentProcess = Process.GetCurrentProcess();

        double totalSeconds = (DateTime.Now - currentProcess.StartTime).TotalSeconds;
        //Console.WriteLine($"{message}");
        Console.WriteLine($"[{totalSeconds.ToString("F4")}][{logLevel}][{script}] : {message}\n");
    }
}