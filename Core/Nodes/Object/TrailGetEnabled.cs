/*
 * Filename: TrailGetEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target Motion Trail object is enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (Motion Trail)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f3e39f47-1835-4d09-8e19-d3e9d661990b")]
public class TrailGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Get Enabled";
    public string GetVariableQualifiedName() => "trailGetEnabled";
}