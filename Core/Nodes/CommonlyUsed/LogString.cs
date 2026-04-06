/*
 * Filename: LogString.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Logs a string to the logging tab of your palette.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Text (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("4047a8cc-3dcc-4fa8-85a7-41d569b8e547")]
public class LogString : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Log String";
    public string GetVariableQualifiedName() => "logString";
}