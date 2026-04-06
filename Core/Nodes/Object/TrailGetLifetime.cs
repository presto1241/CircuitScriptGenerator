/*
 * Filename: TrailGetLifetime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the lifetime of the target Motion Trail object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Motion Trail)
 *
 * OUTPUTS: 
 * Lifetime (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0f069b0b-6f70-4386-9c7f-1343661e8df6")]
public class TrailGetLifetime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trail Get Lifetime";
    public string GetVariableQualifiedName() => "trailGetLifetime";
}