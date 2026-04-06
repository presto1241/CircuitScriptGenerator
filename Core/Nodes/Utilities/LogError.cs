/*
 * Filename: LogError.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Logs the given error message to the logging tab of your palette.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Error (string)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("5aadca49-47b3-423e-b536-6b41b0acbfde")]
public class LogError : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Log Error";
    public string GetVariableQualifiedName() => "logError";
}